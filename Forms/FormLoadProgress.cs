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
    public partial class FormLoadProgress : Form
    {
        public FormLoadProgress()
        {
            InitializeComponent();
        }

        public void setText(string textTo)
        {
            infoTo.Text = textTo;
        }
    }
}
