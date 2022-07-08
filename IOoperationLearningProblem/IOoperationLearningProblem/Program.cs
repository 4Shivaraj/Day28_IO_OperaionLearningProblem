// See https://aka.ms/new-console-template for more information
namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To IO Learning Problems");
            Console.WriteLine("1 for Jason Serialise");
            Console.WriteLine("2 for Jason Deserialise");
            Console.WriteLine("3 for Xml Serialise");
            Console.WriteLine("4 for Xml DeSerialise");
            Console.WriteLine("5 for Csv Serialise");
            Console.WriteLine("6 for Csv DeSerialise");
            Console.WriteLine("7 for Read From Csv Write Into Json");
            Console.WriteLine("8 for Read From Json Write Into Csv");

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    //JasonDataOperaton.JsonSerialize();
                    Console.ReadLine();
                    break;
                case 2:
                    JasonDataOperaton.JsonDeserialize();
                    Console.ReadLine();
                    break;
                case 3:
                    XMLDataOperations.XmlSeialize();
                    Console.ReadLine();
                    break;
                case 4:
                    XMLDataOperations.XmlDeSeialize();
                    Console.ReadLine();
                    break;
                case 5:
                    //CsvFileDataOperations.CSVSerialize();
                    Console.ReadLine();
                    break;
                case 6:
                    CsvFileDataOperations.CSVDeserialize();
                    Console.ReadLine();
                    break;
                case 7:
                    CsvAndJsonOperations.ReadFromCsvWriteIntoJson();
                    Console.ReadLine();
                    break;
                case 8:
                    CsvAndJsonOperations.ReadFromJsonWriteIntoCsv();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }

    }
}

//Read From Csv Write Into Json
//In readFromCsvWriteIntoJson.Json
//C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\readFromCsvWriteIntoJson.Json

//Result:
/*
[
  
  {
    "PersonId": 12,
    "Name": "Shivaraj",
    "Address": "Bangalore"
  },
  {
    "PersonId": 13,
    "Name": "Vinay",
    "Address": "Tumkur"
  },
  {
    "PersonId": 12,
    "Name": "Manu",
    "Address": "Hasan"
  }
]
*/
//--------------------------------------------//

//Read From Json Write Into Csv
//C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\readFromJsonWriteIntocsv.csv

//PersonId,Name,Address
//12,Shivaraj,Delhi
//13,Arun,Bangalore
//12,Deepak,Bangal

