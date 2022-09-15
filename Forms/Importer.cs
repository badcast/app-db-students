using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBaseStudents
{


    public partial class Importer : Form
    {
        Plugins.PluginFormat pfrm = Plugins.PluginFormats.GetExtension(Plugins.FormatType.Excel);
        public Importer()
        {

            InitializeComponent();
        }

        private ImporterDetail getDetail()
        {
            return new ImporterDetail() { isAddNewer = rb_addNewOnReplace.Checked, isAskQuestion = rb_askDetail.Checked };
        }

        private void toDef()
        {
            rb_deleteAll.Checked = true;
            rb_askDetail.Checked = true;
            l_name.Text = "Имя расширения: " + pfrm.FormatName;
            l_ext.Text = "Расширение файла: " + pfrm.Extension;
            l_ver.Text = "Версия: " + pfrm.Importer.Version.ToString();
        }

        private void Importer_Load(object sender, EventArgs e)
        {
            this.Shown += (o, ee) =>
            {
                toDef();
            };

            rb_deleteAll.CheckedChanged += (o, ee) =>
            {
                askPanel.Enabled = !rb_deleteAll.Checked;
            };
        }

        public bool ShowDialog(out ImporterDetail import, Plugins.PluginFormat plugin)
        {
            import = default(ImporterDetail);
            this.pfrm = plugin;
            if (this.ShowDialog() != DialogResult.OK)
                return false;

            import = getDetail();
            return true;

        }

        private void bImport_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void Importer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel && MessageBox.Show("Не сохраненные данные будут потеряны. Вы уверены?", "Предупреждение",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
    }

    public class ImporterDetail
    {
        public bool isAddNewer;
        public bool isAskQuestion;
    }
}
