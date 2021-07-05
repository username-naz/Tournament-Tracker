using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextFileConnection : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";


        public PrizeModel CreatePrize(PrizeModel model)
        {
            int currentId;

            List<PrizeModel> 
                prizes = PrizesFile
                .FullFilePath()
                .LoadFile()
                .ConvertToPrizeModels();

            if (prizes.Count > 0)
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            else
                currentId = 1;

            model.Id = currentId;
            prizes.Add(model);

            prizes.SavetoPrizesFile(PrizesFile);

            return model;
        }
        public void CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }
    }
}
