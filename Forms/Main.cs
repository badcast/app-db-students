using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DataBaseStudents
{
    public partial class Main : Form
    {
        private ProfileWindow profWindow;
        private PasswordManager passmgrWindow;
        private Forms.About about;
        private Importer importerWindow;
        private ImportinProgress importProgWindow;
        public DataBase DataBase;
        private SaveFileDialog _fileDIalog = new SaveFileDialog() { CheckPathExists = false, CheckFileExists = false, Title = "Экспорт"};
        private OpenFileDialog _fileDIalogImport = new OpenFileDialog() { CheckFileExists = true, Title = "Импорт", CheckPathExists = false};

        public Main()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            profWindow = new ProfileWindow();
            passmgrWindow = new PasswordManager();
            about = new Forms.About();
            importerWindow = new Importer();
            importProgWindow = new ImportinProgress();
            refreshState();
            data.CellMouseDoubleClick += (o, e) =>
            {
                if (e.Button != MouseButtons.Left)
                    return;
                ProfileEdit();
            };
        }

        public void ProfileEdit()
        {
            if (DataBase.current == null)
                return;
            DataBase.DProfile prof01 = DataBase.current;
            DataBase.DProfile prof = prof01;
            if (profWindow.ShowDialogEdit(ref prof))
                DataBase.ChangeProfileTo(prof01, prof);
        }

        public void ProfileAdd()
        {

            DataBase.DProfile prof = null;
            reload:
            if (profWindow.ShowDialogCreate(out prof))
            {
                if (DataBase.HasProfile(prof))
                {
                    MessageBox.Show("Объект уже существует.", "Невозможно заменить существующий объект", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!DataBase.AddProfile(prof))
                {
                    if (MessageBox.Show("Объект оказался пустым или не доступен.\nПовторить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        goto reload;
                }
            }
        }

        public void ProfileDelete()
        {
            var selected = data.SelectedRows;
            if (selected.Count <= 0)
                return;
            if (MessageBox.Show("Удалить ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var pf = DataBase.profiles;
                List<DataBase.DProfile> _totalList = new List<DataBase.DProfile>();
                for (int i = 0; i < selected.Count; i++)
                {
                    var el = pf[selected[i].Index];
                    _totalList.Add(el);
                }

                for (int i = 0; i < _totalList.Count; i++)
                {
                    var p = _totalList[i];
                    pf.Remove(p);
                }

                DataBase.RefreshView();
            }

        }

        private FormLoadProgress f;
        public void ExportTo(Plugins.FormatType formatType)
        {
            var ext = Plugins.PluginFormats.GetExtension(formatType);

            this._fileDIalog.Filter = $"{ext.FormatName}|*{ext.Extension}";
            if (_fileDIalog.ShowDialog() == DialogResult.OK)
            {
                string fileName = _fileDIalog.FileName;
                _fileDIalog.FileName = "";

                ExportTo(fileName, formatType);
            }
        }
        public void ExportTo(string fileName, Plugins.FormatType formatType)
        {
            bool isTaskComplete = false;
            bool isError = false;
            f = new FormLoadProgress();
            f.FormBorderStyle = FormBorderStyle.None;
            f.FormClosing += (o, e) =>
            {
                if (!isTaskComplete) e.Cancel = true;
            };
            f.timer1.Tick += (o, e) =>
            {
                if (isTaskComplete)
                    f.Close();
            };
            Thread t = new Thread(() =>
            {
                isTaskComplete = false;
                try
                {
                    string message = "";
                    MessageBoxIcon msType = MessageBoxIcon.Information;
                    if (Plugins.SavePlugin.SaveTo(fileName, DataBase, formatType))
                    {
                        message = "Данные успешно сохранены.";
                    }
                    else
                    {
                        message = "Плагин не существует или поврежден.\nПодробнее в \"Настройки->Плагины\"";
                        msType = MessageBoxIcon.Warning;
                    }
                    if (msType != MessageBoxIcon.Information)
                        MessageBox.Show(message, "Ошибка плагина", MessageBoxButtons.OK, msType);
                }
                catch
                {
                    isError = true;
                }
                isTaskComplete = true;
            });
            t.Start();
            f.ShowDialog();
            f.Dispose();
            f = null;

            if (isError)
            {
                MessageBox.Show("Ошибка при сохранений файла. Возможен сбой внутренного или внешнего кода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void ExportToAnyFormat()
        {
            var exts = Plugins.PluginFormats.GetExtensions();

            this._fileDIalog.Filter = "";
            for (int i = 0; i < exts.Length; i++)
            {
                var ext = exts[i];
                this._fileDIalog.Filter += (i != 0 ? "|" : string.Empty) + $"{ext.FormatName}|*{ext.Extension}";

            }

            if (_fileDIalog.ShowDialog() == DialogResult.OK)
            {
                var selExt = exts[_fileDIalog.FilterIndex];
                string fileName = _fileDIalog.FileName;
                _fileDIalog.FileName = "";


                ExportTo(fileName, selExt.FormatType);
            }
        }

        public void ImportTo()
        {
            var exts = Plugins.PluginFormats.GetExtensions();
            int pluginNotExists = 0;
            this._fileDIalogImport.Filter = "";
            for (int i = 0; i < exts.Length; i++)
            {
                var ext = exts[i];
                if (!ext.HasImporter)
                {
                    pluginNotExists++;
                    continue;
                }
                string extX = (i - pluginNotExists != 0 ? "|" : string.Empty) + $"{ext.FormatName}|*{ext.Extension}";
                this._fileDIalogImport.Filter += extX;
            }
            if (_fileDIalogImport.ShowDialog() != DialogResult.OK)
                return;

            Plugins.PluginFormat selExt = exts[exts.Length - pluginNotExists];
            string fileName = _fileDIalogImport.FileName;
            Plugins.FormatType formatType = selExt.FormatType;


            bool isTaskComplete = false;
            bool isError = false;
            string msgTo = "";
            f = new FormLoadProgress();
            f.FormBorderStyle = FormBorderStyle.None;
            f.FormClosing += (o, e) =>
            {
                if (!isTaskComplete) e.Cancel = true;
            };
            f.timer1.Tick += (o, e) =>
            {
                if (isTaskComplete)
                    f.Close();
                f.setText(msgTo);
            };

            string[][] buffers = null;
            Thread t = new Thread(() =>
            {
                isTaskComplete = false;
                try
                {
                    msgTo = "Запуск расширения: " + selExt.FormatName;
                    Thread.Sleep(1000);
                    buffers = Plugins.LoadPlugin.LoadFrom(_fileDIalogImport.FileName, selExt.FormatType);
                    //   message = "Плагин не существует или поврежден.\nПодробнее в \"Настройки->Плагины\"\n\tПроблема может быть из за не обновленной версий, попробуйте обновить его.";
                    msgTo = "Обработка выполнена... инициализация";
                    Thread.Sleep(2000);

                    ImporterDetail iid;
                    if (importerWindow.ShowDialog(out iid, selExt))
                    {
                        msgTo = "Начало импорта";
                        Thread.Sleep(1000);
                        int leng = buffers.GetLength(0);
                        DataBase.DProfile[] __data = new DataBase.DProfile[leng];
                        string getVal(int row, int column)
                        {
                            return buffers[row][column] ?? "";
                        }
                        for (int i = 0; i < leng; i++)
                        {
                            string IIN = getVal(i, 0);
                            string[] fio = getVal(i, 1).Split(' ');
                            string lastName = fio[0];
                            string name = fio[1];
                            string familyName = fio[2];
                            string email = getVal(i, 2);
                            string telNumber = getVal(i, 3);
                            string date = getVal(i, 4);
                            string national = getVal(i, 5);
                            string spec = getVal(i, 6);
                            string addressofhome = getVal(i, 7);

                            DateTime dt = DateTime.Now;
                            DateTime.TryParse(date, out dt);
                            DataBase.DProfile d = __data[i] = new DataBase.DProfile(name, lastName, familyName, dt, spec, "", "", false,    false, false, false, false, addressofhome, telNumber, email, IIN, national);
                            //f[1] = "'" + prof.IIN;                                      //ИИН
                            //f[2] = $"{prof.LastName} {prof.Name} {prof.FamilyName}";    //фио
                            //f[3] = prof.Email;                                          //почта
                            //f[4] = "'" + prof.TelephoneNumber;                          //номер телефона
                            //f[5] = prof.Date.ToShortDateString();                                           //дата рождения
                            //f[6] = prof.National;                                       //национальность
                            //f[7] = prof.Speciality;                                     //специальность
                            //f[8] = prof.AddressOfHome;                                  //адрес проживания
                            DataBase.profiles.Add(d);
                            msgTo = string.Format("Общий прогресс: {0}", 100 * i / leng);
                        }
                        msgTo = "Завершение импорта";
                        Thread.Sleep(1000);

                    }

                }
                catch
                {
                    isError = true;
                }
                isTaskComplete = true;
            });
            t.Start();
            f.ShowDialog();
            f.Dispose();
            f = null;
            DataBase.RefreshView();

            if (isError)
            {
                MessageBox.Show("Ошибка импортирования файла. Возможен сбой внутренного или внешного кода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProfileEdit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProfileAdd();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProfileDelete();
        }

        private void менеджерПаролейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passmgrWindow.ShowDialog();
        }

        private void оАвторахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wordDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTo(Plugins.FormatType.Word);
        }

        private void wordRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTo(Plugins.FormatType.RTF);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTo(Plugins.FormatType.Excel);
        }

        private void picturePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTo(Plugins.FormatType.PDF);
        }

        private void экспортироватьИСохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToAnyFormat();
        }

        private void refreshState()
        {
            __delete.Enabled = btnDelete.Enabled = data.SelectedRows.Count > 0;
            __edit.Enabled = btnEdit.Enabled = data.SelectedRows.Count == 1;

        }

        private void data_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ProfileDelete();
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshState();
        }

        private void data_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            refreshState();


        }

        private void __edit_Click(object sender, EventArgs e)
        {
            ProfileEdit();
        }

        private void __add_Click(object sender, EventArgs e)
        {
            ProfileAdd();
        }

        private void __delete_Click(object sender, EventArgs e)
        {
            ProfileDelete();
        }

        private void импортироватьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportTo();
        }
    }
}
