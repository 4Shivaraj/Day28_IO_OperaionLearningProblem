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
                case 6:
                    CsvFileDataOperations.CSVDeserialize();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }

    }
}

//CSV DeSerialization
//In Console

//Result:
//Welcome To IO Learning Problems
//1 for Jason Serialise
//2 for Jason Deserialise
//3 for Xml Serialise
//4 for Xml DeSerialise
//5 for Csv Serialise
//6 for Csv DeSerialise
//6
//Id:12   Name: Shivaraj Address: Bangalore
//Id:13   Name: Vinay Address: Tumkur
//Id:12   Name: Manu Address: Hasan
