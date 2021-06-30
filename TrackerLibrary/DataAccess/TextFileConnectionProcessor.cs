    using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TrackerLibrary.DataAccess.TextFileConnection
{
    class TextFileConnectionProcessor
    {
        public static string FullFilePath(string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

    }
}