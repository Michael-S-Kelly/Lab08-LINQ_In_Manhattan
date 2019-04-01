using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LINQInManhattan.Classes;
using System.Collections.Generic;

namespace LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../../data.json";
            FeatureCollection raw = GetJson(path);
            bool menu = true;

            while (menu)
            {
                menu = NavMenu(raw);
            }
             
        }

        /// <summary>
        /// Navigates between the different query printouts and exit program
        /// </summary>
        /// <param name="raw">Deserialized Json data</param>
        /// <returns></returns>
        static bool NavMenu(FeatureCollection raw)
        {
            Console.Clear();
            Console.WriteLine("1) Print all Properties (unfiltered)");
            Console.WriteLine("2) Print all Properties (known neighborhoods)");
            Console.WriteLine("3) Print all Properties (known neighborhoods (alternate search))");
            Console.WriteLine("4) Print all Properties (duplicates removed)");
            Console.WriteLine("5) Print all Properties (known neighborhood & duplicates removed)");
            Console.WriteLine("6) Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                PrintAllRaw(raw);
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                return true;
            }
            else if (choice == "2")
            {
                Console.Clear();
                PrintKnownNeighborhoods(raw);
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                return true;
            }
            else if (choice == "3")
            {
                Console.Clear();
                PrintKnownNeighborhoodsAlt(raw);
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                return true;
            }
            else if (choice == "4")
            {
                Console.Clear();
                PrintAllNoDups(raw);
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                return true;
            }
            else if (choice == "5")
            {
                Console.Clear();
                PrintKnownNeighborhoodsNoDups(raw);
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                return true;
            }
            else if (choice == "6")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
        /// <summary>
        /// Brings data in from Json, Deserializes it, and gives it to the FeatureCollection
        /// </summary>
        /// <param name="path">source file for the data.Json file</param>
        /// <returns>Raw form of the deserialized FeatureCollection</returns>
        static FeatureCollection GetJson(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                var data = "";
                data = sr.ReadToEnd();
                FeatureCollection raw = JsonConvert.DeserializeObject<FeatureCollection>(data);
                return raw;
            }
        }

        #region Query methods to execute for options 1 through 5 of NavMenu method
        /// <summary>
        /// Grabs the deserialized data from the Json file and prints out all the properties
        /// </summary>
        /// <param name="raw">Deserialized data from the Json file</param>
        static object PrintAllRaw(FeatureCollection raw)
        {
            var data = from feature in raw.Features
                       select feature.Properties.Neighborhood;
                       

            foreach (var property in data)
            {
                Console.WriteLine(property);
            }

            return data;

        }


        /// <summary>
        /// Prints a list of all the Neighborhoods with out blanks
        /// </summary>
        /// <param name="raw">Deserialized data from the Json file</param>
        static void PrintKnownNeighborhoods(FeatureCollection raw)
        {
            var data = from feature in raw.Features
                       where (feature.Properties.Neighborhood != "")
                       select feature.Properties.Neighborhood;


            foreach (var property in data)
            {
                Console.WriteLine(property);
            }
        }

        /// <summary>
        /// Alternate version of the PrintKnownNeighborhoods method
        /// </summary>
        /// <param name="raw">Deserialized data from the Json file</param>
        static void PrintKnownNeighborhoodsAlt(FeatureCollection raw)
        {
            var data = raw.Features.Where(neighbors => neighbors.Properties.Neighborhood != "");

            foreach (var property in data)
            {
                Console.WriteLine(property.Properties.Neighborhood);
            }
        }

        /// <summary>
        /// Prints a list of all the Neighborhoods with out duplication
        /// </summary>
        /// <param name="raw">Deserialized data from the Json file</param>
        static void PrintAllNoDups(FeatureCollection raw)
        {
            var data = from feature in raw.Features
                       group feature by feature.Properties.Neighborhood
                       into neighborhoods
                       select neighborhoods;


            foreach (var property in data)
            {
                Console.WriteLine(property.Key);
            }
        }

        /// <summary>
        /// Prints a list of all the Neighborhoods with out duplication or blanks
        /// </summary>
        /// <param name="raw">Deserialized data from the Json file</param>
        static void PrintKnownNeighborhoodsNoDups(FeatureCollection raw)
        {
            var data = from feature in raw.Features
                       where (feature.Properties.Neighborhood != "")
                       group feature by feature.Properties.Neighborhood
                       into neighborhoods
                       select neighborhoods;



            foreach (var property in data)
            {
                Console.WriteLine(property.Key);
            }
        }
        #endregion
    }
}
