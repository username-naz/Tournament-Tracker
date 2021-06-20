using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPrizePercentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {

        }

        private bool IsValid()
        {
            bool valid = true;
            int placeNumber;
            bool validPlaceNumber = int.TryParse(txtBoxPlaceNumber.Text, out placeNumber) || placeNumber < 1;
            if (!validPlaceNumber)
            {
                valid = false;
            }


            return valid;
        }
    }
}
