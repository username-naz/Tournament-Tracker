using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GolbalConfig.CnnString("Tournaments")))
            {
                /*
                @PlaceNumber int,
                @PlaceName nvarchar(50),
                @PrizeAmount money,
                @PrizePercentage float,
                @id int = 0 output
                */
                
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
            }

            return model;
        }
    }
}
