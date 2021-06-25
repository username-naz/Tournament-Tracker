using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GolbalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitialiseConnections(bool useDatabase, bool useTextFiles) {
            if (useDatabase)    
            {
                //TODO -  Create SQL Connection

                var sqlConnection = new SqlConnection();
                Connections.Add(sqlConnection);
            }

            if (useTextFiles)
            {
                //TODO - Create Text File Connection
                var textFileConnection = new TextFileConnection();
                Connections.Add(textFileConnection);
            }
        }

        public static string CnnString(string name)
        {return ConfigurationManager.ConnectionStrings[name].ConnectionString;}
    }
}
