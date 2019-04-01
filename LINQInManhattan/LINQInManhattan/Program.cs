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
                return true;
            }
            else if (choice == "3")
            {
                Console.Clear();
                PrintKnownNeighborhoodsAlt(raw);
                return true;
            }
            else if (choice == "4")
            {
                Console.Clear();
                PrintAllNoDups(raw);
                return true;
            }
            else if (choice == "5")
            {
                Console.Clear();
                PrintKnownNeighborhoodsNoDups(raw);
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
        static void PrintAllRaw(FeatureCollection raw)
        {
            var data = from feature in raw.Features
                       select raw.Features;

            foreach (var property in data)
            {
                Console.WriteLine(property);
            }
        }

        static void PrintKnownNeighborhoods(FeatureCollection raw)
        {

        }

        static void PrintKnownNeighborhoodsAlt(FeatureCollection raw)
        {

        }

        static void PrintAllNoDups(FeatureCollection raw)
        {

        }

        static void PrintKnownNeighborhoodsNoDups(FeatureCollection raw)
        {

        }
        #endregion
        //TODO: Bring the Json data into the program
        //TODO: Convert the data into a LINQ
        //TODO: Output all of the neighborhoods in the data list
        //TODO: Filter out all the neighborhoods that do not have any names
        //TODO: Remove the Duplicates
        //TODO: Rewrite the queries from above, and consolidate all into one single query
        //TODO: Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vise versa.)

        /*
        var data = File.ReadAllText(path);
        var raw = JsonConvert.DeserializeObject<List<FeatureCollection>>(data);
        */

        /*
        var data = "";
        using (StreamReader sr = File.OpenText(path))
        {
            data = sr.ReadToEnd();
        }

        RootObject root = JsonConvert.DeserializeObject<RootObject>(data);
        */

        /*
        var raw = GetJson(path);
        */
    }
}
