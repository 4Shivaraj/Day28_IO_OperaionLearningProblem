using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    /// <summary>
    /// Json Input and Output Operations
    /// </summary>
    class JasonDataOperaton
    {
        /// <summary>
        /// Jsons the serialize
        /// </summary>
        public static void JsonSerialize()
        {
            string jsonPath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\JsonData.json";
            //Object Intialiser Instead if adding person.personId = 12
            //Object Intialiser = We can intialise the value to the fields or property of a class
            //at the time of creating object without calling a constructor.
            List<Person> person = new List<Person>()

            {
               new Person(){PersonId = 12, Name = "Shivaraj", Address = "Delhi"},
               new Person(){PersonId = 13, Name = "Arun", Address = "Bangalore"},
               new Person(){PersonId = 12, Name = "Deepak", Address = "Bangal"},
            };
            //Serialise Object method used to convert from object into json data
            string result = JsonConvert.SerializeObject(person);
            //Writing in to file
            File.WriteAllText(jsonPath, result);
        }
        public static void JsonDeserialize()
        {
            string jsonPath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\JsonData.json";
            if (IsFileExists(jsonPath))
            {
                string JsonData = File.ReadAllText(jsonPath);
                List<Person> result = JsonConvert.DeserializeObject<List<Person>>(JsonData);
                if (result.Count != 0)
                {
                    foreach (Person person in result)
                    {
                        Console.WriteLine(person);
                    }
                }
            }
        }
        public static bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                return true;
            }
            else
            {
                Console.WriteLine("File Not Exists");
                return false;
            }
        }

    }
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Id:"+PersonId + " " + "\tName:"+" "+Name + " " + "\tAddress:" + " "+Address;
        }
    }
}
