using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    class CsvFileDataOperations
    {
        public static void CSVSerialize()
        {
            StreamWriter sw = null;
            CsvWriter csvWriter = null;

            try
            {
                string csvPath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\CsvData.csv";

                List<Person> person = new List<Person>()
                {
                    new Person() { PersonId = 12, Name = "Shivaraj", Address = "Bangalore" },
                    new Person() { PersonId = 13, Name = "Vinay", Address = "Tumkur" },
                    new Person() { PersonId = 12, Name = "Manu", Address = "Hasan" },
                };
                sw = new StreamWriter(csvPath);
                csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sw.Close();
                csvWriter.Dispose();
            }
        }
    }
}