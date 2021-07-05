using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitialiseConnections(DataBaseType type) {
            switch (type)
            {
                case DataBaseType.SQL:
                    Connection = new SqlConnection();
                    break;
                case DataBaseType.TEXT_FILE:
                    Connection = new TextFileConnection();
                    break;
                default:
                    break;
            }
        }

        public static string CnnString(string name)
        {return ConfigurationManager.ConnectionStrings[name].ConnectionString;}
    }
}
