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
    public partial class KeyUsage : Form
    {
        private Image[] _icons;
        private string[] _text = { "Введенный ключ должен быть четко определен.", "Неверный ключ подтверждения."};
        public bool IsKeyed { get; private set; }
        public KeyUsage()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _icons = new Image[] { Properties.Resources.icon_warning, Properties.Resources.icon_error};
            this.Shown += (o, e) => CodeType(0);
            this.TopMost = true;
                CodeType(0);
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if (key == Properties.Resources._defKey || HasKey(key))
            {
                IsKeyed = true;
                this.Close();
                return;
            }

            CodeType(1);
        }

        private bool HasKey(string key)
        {
            return KeyProfiles.keyProfiles.ExistKey(key);
        }

        private void CodeType(int cmd)
        {
            icn.Image = _icons[cmd];
            info.Text = _text[cmd];
            textBox1.Text = "";
            IsKeyed = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                enter_Click(null, null);
            }
        }
    }
}
