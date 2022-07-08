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
                default:
                    break;
            }

        }

    }
}

//Xml Serialization
//"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\XmlData.txt";

//Result:
//<?xml version="1.0" encoding="utf-8"?><ArrayOfPerson xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
//<Person><PersonId>12</PersonId><Name>Shivaraj</Name><Address>Bangalore</Address></Person>
//<Person><PersonId>13</PersonId><Name>Shravan</Name><Address>Mangalore</Address></Person>
//<Person><PersonId>12</PersonId><Name>Theekshna</Name><Address>Tumkur</Address></Person>
//</ArrayOfPerson>