using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {   
            model.Id = 1;
            return model;
        }
    }
}
