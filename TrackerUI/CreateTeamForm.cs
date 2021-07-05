using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {

        }

        private void txtEntryFee_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxEntryFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                var model = new PersonModel();
                model.FirstName = txtBoxFirstName.Text;
                model.LastName = txtBoxLastName.Text;
                model.Email = txtBoxEmail.Text;
                model.PhoneNumber = txtBoxPhoneNumber.Text;

                GlobalConfig.Connection.CreatePerson(model);

                txtBoxFirstName.Text = "";
                txtBoxLastName.Text = "";
                txtBoxEmail.Text = "";
                txtBoxPhoneNumber.Text = "";
            }
            else
                MessageBox.Show("Please enter all the fields");
        }

        private bool isValidForm() {
            if (txtBoxFirstName.Text.Length * txtBoxLastName.Text.Length * txtBoxEmail.Text.Length * txtPhoneNumber.Text.Length == 0)
                return false;

           return true;
        }
    }
}
