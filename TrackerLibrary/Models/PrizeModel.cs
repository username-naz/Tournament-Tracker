using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {   
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public int PlaceNumber { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel (string PlaceName, string PlaceNumber, string PrizeAmount, string PrizePercentage)
        {
            this.PlaceName = PlaceName;

            int placeNumberValue = 0;
            int.TryParse(PlaceNumber, out placeNumberValue);
            this.PlaceNumber = placeNumberValue;
        
            decimal prizeAmountValue = 0;
            decimal.TryParse(PrizeAmount, out prizeAmountValue);
            this.PrizeAmount = prizeAmountValue;

            int prizePercentageValue = 0;
            int.TryParse(PrizePercentage, out prizePercentageValue);
            this.PrizePercentage = prizePercentageValue;


        }
    }
}
