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

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    JasonDataOperaton.JsonSerialize();
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
                    CsvFileDataOperations.CSVSerialize();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }

    }
}

//CSV Serialization
//"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\CsvData.csv";

//Result:
//PersonId,Name,Address
//12,Shivaraj,Bangalore
//13,Vinay,Tumkur
//12,Manu,Hasan
