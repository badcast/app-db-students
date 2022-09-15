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
    public partial class PasswordManager : Form
    {
        private AddNewUser addNewUserWindow;
        private string ToLabel { get { return getInfoUserName.Text; } set { getInfoUserName.Text = value == null ? "(Не выбран пользователь)" : value; } }
        public PasswordManager()
        {
            InitializeComponent();
            if (DesignMode)
                return;
            this.Shown += (o, e) => Refresh();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            if (addNewUserWindow == null)
                addNewUserWindow = new AddNewUser();

            if (addNewUserWindow.ShowDialog() == DialogResult.OK)
            {
                string sUser = addNewUserWindow._user.Text;
                string pPass = addNewUserWindow._pass.Text;

                System.Threading.Thread.Sleep(1000);

                if (!Program.kfeData.AddKey(sUser, pPass))
                {
                    MessageBox.Show($"Пользователь {sUser} уже существует.", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Новый пользователь \"{sUser}\" успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            addNewUserWindow._user.Text = "";
            addNewUserWindow._pass.Text = "";
            Refresh();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refresh()
        {
            string[] users = Program.kfeData.GetUsers();

            listBox1.Items.Clear();
            for (int i = 0; i < users.Length; i++)
            {
                listBox1.Items.Add(users[i]);
            }
            if (listBox1.SelectedIndex < 0 && listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            ToLabel = listBox1.SelectedIndex < 0 ? null : listBox1.SelectedItem.ToString();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            string user = listBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(user))
            {
                string s = "";
                if (MessageBox.Show($"Удалить пользователя \"{user}\"", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!Program.kfeData.DeleteUser(user))
                    {
                        s = "Пользователь не был удален. Возможно он не существует.";
                    }
                    else
                    {
                        s = "Пользователь успешно удален.";
                    }
                    MessageBox.Show(s, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    return;
            }

            Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToLabel = listBox1.SelectedItem.ToString();
        }
    }
}
