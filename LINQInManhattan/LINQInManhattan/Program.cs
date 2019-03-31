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
            var data = "";
            

            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }

            var raw = JsonConvert.DeserializeObject<List<FeatureCollection>>(data);


            bool menu = true;
            while (menu)
            {
                menu = NavMenu(raw);
            }
             
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        static bool NavMenu(List<FeatureCollection> raw)
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

        /*
        /// <summary>
        /// Brings data in from Json, Deserializes it, and gives it to the FeatureCollection
        /// </summary>
        /// <param name="path">source file for the data.Json file</param>
        /// <returns>Raw form of the deserialized FeatureCollection</returns>
        static var GetJson(string path)
        {
            var data = File.ReadAllText(path);
            var raw = JsonConvert.DeserializeObject<List<FeatureCollection>>(data);
            return raw;

        }
        */

        /*
        private static List<RetrieveMultipleResponse> GetRaw(string data)
        {
            return JsonConvert.DeserializeObject<List<RetrieveMultipleResponse>>(data);
        }
        */
        #region Query methods to execute for options 1 through 5 of NavMenu method
        static void PrintAllRaw(List<FeatureCollection> raw)
        {
            var data = from feature in raw
                       select feature.Features;
        }

        static void PrintKnownNeighborhoods(List<FeatureCollection> raw)
        {

        }

        static void PrintKnownNeighborhoodsAlt(List<FeatureCollection> raw)
        {

        }

        static void PrintAllNoDups(List<FeatureCollection> raw)
        {

        }

        static void PrintKnownNeighborhoodsNoDups(List<FeatureCollection> raw)
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
