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
    public partial class AddNewUser : Form
    {
        public bool added;
        public AddNewUser()
        {
            InitializeComponent();
        }

        private bool _CorrectString(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 3)
                return false;
            return true;
        }

        private void ShowMessage(string Text)
        {
            MessageBox.Show(this, Text, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            added = false;
            if (!_CorrectString(_user.Text))
            {
                ShowMessage("Не верно указан имя пользователя.");
                return;
            }
            if(!_CorrectString(_pass.Text))
            {
                ShowMessage("Не верно указан ключ.");
                return;
            }
            added = true;
            DialogResult = DialogResult.OK;
        }

        private void AddNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!added)
            {
                DialogResult = DialogResult.No;
            }
            
            added = false;
        }
    }
}
