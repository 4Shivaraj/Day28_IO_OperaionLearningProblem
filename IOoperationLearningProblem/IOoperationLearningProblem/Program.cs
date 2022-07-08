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
                default:
                    break;
            }

        }

    }
}

//Xml DeSerialization
//"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\XmlData.txt";

//Result:
//Welcome To IO Learning Problems
//1 for Jason Serialise
//2 for Jason Deserialise
//3 for Xml Serialise
//4 for Xml DeSerialise
//4
//File Exists
//Id:12   Name: Shivaraj Address: Bangalore
//Id:13   Name: Shravan Address: Mangalore
//Id:12   Name: Theekshna Address: Tumkur