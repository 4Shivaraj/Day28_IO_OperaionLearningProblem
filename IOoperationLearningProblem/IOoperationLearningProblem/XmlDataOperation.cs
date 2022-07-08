using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOOperation
{
    class XMLDataOperations
    {
        public static void XmlSeialize()
        {
            StreamWriter sw = null;

            try
            {
                string xmLpath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\XmlData.txt";
                List<Person> person = new List<Person>()
                {
                   new Person(){PersonId = 12, Name = "Shivaraj", Address = "Bangalore"},
                   new Person(){PersonId = 13, Name = "Shravan", Address = "Mangalore"},
                   new Person(){PersonId = 12, Name = "Theekshna", Address = "Tumkur"},
                };
                
                XmlSerializer xml = new XmlSerializer(typeof(List<Person>));

                sw = new StreamWriter(xmLpath);
                xml.Serialize(sw, person);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex.Message");
            }
            finally
            {
                sw.Close();
            }
        }
        public static void XmlDeSeialize()
        {
            try
            {
                StreamReader sr = null;
                string xmLpath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\XmlData.txt";
                if (JasonDataOperaton.IsFileExists(xmLpath))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
                    sr = new StreamReader(xmLpath);
                    List<Person> result  = (List<Person>)xml.Deserialize(sr);
                    if (result.Count != 0)
                    {
                        foreach (Person person in result)
                        {
                            Console.WriteLine(person);
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}