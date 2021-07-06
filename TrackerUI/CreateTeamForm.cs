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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetListOfAllPeople();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Timmy", LastName = "Jim" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Joshua", LastName = "Chaplin" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Bostin" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Marry", LastName = "Lee" });

        }
        private void WireUpLists()
        {
            comboSelectTeamMember.DataSource = availableTeamMembers;
            comboSelectTeamMember.DisplayMember = "FullName";

            listBoxTeamMembers.DataSource = selectedTeamMembers;
            listBoxTeamMembers.DisplayMember = "FullName";
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

        private bool isValidForm()
        {
            if (txtBoxFirstName.Text.Length * txtBoxLastName.Text.Length * txtBoxEmail.Text.Length * txtPhoneNumber.Text.Length == 0)
                return false;

            return true;
        }
    }
}
