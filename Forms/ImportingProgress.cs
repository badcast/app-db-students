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


    public partial class ImportinProgress : Form
    {
        public ImportinProgress()
        {
            InitializeComponent();
        }

        private void Importer_Load(object sender, EventArgs e)
        {
        }

        public void writeValue(int progressRange)
        {
            progressBar1.Value = progressRange;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            return;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
