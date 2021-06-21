using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;

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
            if (IsValidData())
            {
                var model = new PrizeModel(
                    txtboxPlaceName.Text,
                    txtBoxPlaceNumber.Text,
                    txtBoxPrizeAmount.Text,
                    txtBoxPrizePercentage.Text
                    );

                GolbalConfig.Connections.ForEach((db) => db.CreatePrize(model));

                txtboxPlaceName.Text = "";
                txtBoxPlaceNumber.Text = "";
                txtBoxPrizeAmount.Text = "0";
                txtBoxPrizePercentage.Text = "0";
            }
            else MessageBox.Show("Invalid data entry. Please check it and try again.");
          
            
        }

        private bool IsValidData()
        {
            bool valid = true;
            int placeNumber;
            bool isValidPlaceNumber = 
                int.TryParse(txtBoxPlaceNumber.Text, out placeNumber) 
                && placeNumber > 0 
                && txtPlaceNumber.Text.Length != 0;

            if (!isValidPlaceNumber) valid = false;
          

            decimal prizeAmount;
            int prizePercentage;
            bool isValidprizeAmount = decimal.TryParse(txtBoxPrizeAmount.Text, out prizeAmount);
            bool isValidPrizePrecentage = int.TryParse(txtBoxPrizePercentage.Text, out prizePercentage);

            if (!isValidprizeAmount || !isValidPrizePrecentage) valid = false;
            if (prizeAmount <= 0 && prizePercentage <= 0) valid = false;
            if (prizePercentage > 100) valid = false;

            return valid;   
        }
    }
}
