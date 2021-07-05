    using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextFileConnectionProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
                return new List<string>();

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            lines.ForEach(line =>
            {
                string[] cols = line.Split(',');

                var p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);           
            });

            return output;
        }
        public static void SavetoPrizesFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            models.ForEach(p =>
            {
                lines.Add($"{ p.Id },{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            });

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            var output = new List<PersonModel>();

            lines.ForEach(line =>
            {
                string[] cols = line.Split(',');

                var p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Email = cols[3];
                p.PhoneNumber = cols[4];

                output.Add(p);
            });

            return output;
        }

        public static void SavetoPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            models.ForEach(p =>
            {
                lines.Add($"{ p.Id },{p.FirstName},{p.LastName},{p.Email},{p.PhoneNumber}");
            });

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}