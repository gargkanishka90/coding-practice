using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ScratchPad.JSON.NET
{
    public class PracticeJSON
    {
        public class Account
        {
            public string Email { get; set; }
            public bool Active { get; set; }
            public DateTime CreatedDate { get; set; }
            public IList<string> Roles { get; set; }
        }

        public class Movie
        {
            public string name { get; set; }
            public int year { get; set; }
        }

        public static string ObjectToJSON()
        {
            var account = new Account
            {
                Email = "gargkanishka90@gmail.com",
                Active = true,
                CreatedDate = DateTime.Now,
                Roles = new List<string>
                {
                    "software developer",
                    "happy"
                }
            };

            return JsonConvert.SerializeObject(account, Formatting.Indented);
        }

        public static string CollectionToJSON()
        {
            List<string> cities = new List<string>
            {
                "Delhi", "Chicago", "Jaipur"
            };

            return JsonConvert.SerializeObject(cities);
        }

        public static string DicttoJSON()
        {
            var dict = new Dictionary<string, int>
            {
                ["kani"] = 112112,
                ["yan"] = 9789,
                ["Mendel"] = 9879
            };
            return JsonConvert.SerializeObject(dict, Formatting.Indented);
        }

        public static bool JSONToFile()
        {
            var movie = new Movie
            {
                name = "Airlift",
                year = 2016
            };

            var path = @"c:\movies.json";

            File.WriteAllText(path, JsonConvert.SerializeObject(movie, Formatting.Indented));
            return true;
        }

        public static bool JSONToFile2()
        {
            var movie = new Movie
            {
                name = "Airlift",
                year = 2016
            };

            var path = @"c:\movies2.json";

            using (StreamWriter file = File.CreateText(path))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
            return true;
        }
    }
}
