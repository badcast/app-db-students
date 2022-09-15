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
    public partial class ProfileWindow : Form
    {
        public ProfileWindow()
        {
            InitializeComponent();
            if (DesignMode)
                return;

        }

        private void ClearMember()
        {
            ShowMember(DataBase.DProfile.Empty);
        }

        private void ShowMember(DataBase.DProfile profile)
        {
            pName.Text = profile.Name;
            pLastName.Text = profile.LastName;
            pFamily.Text = profile.FamilyName;
            pDate.Value = profile.Date;
            pSpeciality.Text = profile.Speciality;
            pFrom9or11.Text = profile.AfterSchool;
            pSchool.Text = profile.School;
            pMedicEx.SelectedIndex = profile.MedicalExmination ? 1 : 0;
            pStatement.Checked = profile.Statement;
            pCertIdentity.Checked = profile.CertificateOfIdentity;
            pCertificate.Checked = profile.Certificate;
            pPhoto.Checked = profile.Photo3or4;
            pAddess.Text = profile.AddressOfHome;
            pTelNumber.Text = profile.TelephoneNumber;
            pEmail.Text = profile.Email;
            pIIN.Text = profile.IIN;
            pNational.Text = profile.National;
        }

        private DataBase.DProfile GetMember()
        {
            return DataBase.DProfile.Create(pName.Text, pLastName.Text, pFamily.Text, pDate.Value, pSpeciality.Text, pFrom9or11.Text, pSchool.Text, pMedicEx.SelectedIndex == 1,
                pStatement.Checked, pCertIdentity.Checked, pPhoto.Checked, pCertificate.Checked, pAddess.Text, pTelNumber.Text, pEmail.Text, pIIN.Text, pNational.Text);
        }

        public bool ShowDialogEdit(ref DataBase.DProfile profile)
        {

            ShowMember(profile);

            bool result = ShowDialog() == DialogResult.OK;

            if(result)
            {
                profile = GetMember();
            }
            ClearMember();

            return result;
        }

        public bool ShowDialogCreate(out DataBase.DProfile profile)
        {
            profile = null;
            bool result = ShowDialog() == DialogResult.OK;
            if(result)
            {
                profile = GetMember();
            }
            ClearMember();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
