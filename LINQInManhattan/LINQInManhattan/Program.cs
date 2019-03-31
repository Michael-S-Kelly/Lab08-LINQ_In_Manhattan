using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using LINQInManhattan.Classes;

namespace LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                menu = NavMenu();
            }
             
        }

        static bool NavMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Run");
            Console.WriteLine("2) Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                return true;
            }
            else if (choice == "2")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Brings data in from Json
        /// </summary>
        static void GetJson()
        {
            string path = "../../../../data.json";


            string data = "";

            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }
        }

        static void DesirializeJson()
        {

        }

        //TODO: Bring the Json data into the program
        //TODO: Convert the data into a LINQ
        //TODO: Output all of the neighborhoods in the data list
        //TODO: Filter out all the neighborhoods that do not have any names
        //TODO: Remove the Duplicates
        //TODO: Rewrite the queries from above, and consolidate all into one single query
        //TODO: Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vise versa.)

    }
}
