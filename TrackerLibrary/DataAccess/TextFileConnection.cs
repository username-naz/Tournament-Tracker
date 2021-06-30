using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public class TextFileConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            
            return model;
        }
    }
}
