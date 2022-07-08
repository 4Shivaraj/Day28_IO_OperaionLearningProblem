using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    class CsvAndJsonOperations
    {
        public static void ReadFromCsvWriteIntoJson()
        {
            string jsonPath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\readFromCsvWriteIntoJson.Json";
            List<Person> list = CsvFileDataOperations.CSVDeserialize();
            JasonDataOperaton.JsonSerialize(list, jsonPath);
        }
        public static void ReadFromJsonWriteIntoCsv()
        {
            string csvPath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\readFromJsonWriteIntocsv.csv";
            List<Person> list = JasonDataOperaton.JsonDeserialize();
            CsvFileDataOperations.CSVSerialize(list, csvPath);

        }
    }
}