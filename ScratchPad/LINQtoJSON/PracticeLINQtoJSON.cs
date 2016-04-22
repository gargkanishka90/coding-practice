using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ScratchPad.LINQtoJSON
{
    public class PracticeLINQtoJSON
    {
        public class Computer
        {
            public string Cpu { get; set; }
            public int Memory { get; set; }
            public IList<string> Drives { get; set; }
        }

        public static string ManualJson()
        {
            var array = new JArray {"manual text", DateTime.Now};

            var o = new JObject {["MyArray"] = array};

            return o.ToString();
        }

        public static string JsonUsingCollectionInitializer()
        {
            var o =  new JObject
            {
                ["cpu"] = "intel",
                ["memory"] = 32,
                ["drives"] = new JArray
                {
                    "dvd", "ssd"
                }
            };
            return o.ToString();
        }

        public static void CreateJsonFromAnObject()
        {
            var i = JToken.FromObject(121212);
            Console.WriteLine(i.Type);
            Console.WriteLine(i.ToString());

            i = (JValue)i;
            Console.WriteLine(i.Type);
            Console.WriteLine(i.ToString());

            i = JToken.FromObject("Kanishka");
            Console.WriteLine(i.Type);
            Console.WriteLine(i.ToString());

            i = (JValue)i;
            Console.WriteLine(i.Type);
            Console.WriteLine(i.ToString());

            var computer = new Computer
            {
                Cpu = "Intel",
                Memory = 32,
                Drives = new List<string>
                {
                    "DVD",
                    "SSD"
                }
            };

            var obj = JToken.FromObject(computer);
            Console.WriteLine(obj.ToString());

            var arr = JToken.FromObject(computer.Drives);
            Console.WriteLine(arr.ToString());
        }

        public static void ParseJsonSchemaFromJson()
        {
            string schemaJson = @"{
                'description': 'A person',
                'type': 'object',
                'properties': {
                'name': {'type':'string'},
                'hobbies': {
                    'type': 'array',
                    'items': {'type':'string'}
                        }
                    }
                }";
            
            JsonSchema schema = JsonSchema.Parse(schemaJson);
            
            Console.WriteLine(schema.Type);
            // Object

            foreach(var property in schema.Properties)
            {
                    Console.WriteLine(property.Key + " - " + property.Value.Type);
            }
            // name - String
            // hobbies - Array
        }
    }
}