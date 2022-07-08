// See https://aka.ms/new-console-template for more information
namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To IO Learning Problems");
            Console.WriteLine("1 for Jason Serialise");
            

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    JasonDataOperaton.JsonSerialize();
                    Console.ReadLine();
                    break;
                
                default:
                    break;
            }

        }

    }
}

//Jason Serialisation
//In JSON File("C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_28\Files\JsonData.json")

//Result:
//[

//  {
//    "PersonId": 12,
//    "Name": "Shivaraj",
//    "Address": "Delhi"
//  },
//  {
//    "PersonId": 13,
//    "Name": "Arun",
//    "Address": "Bangalore"
//  },
//  {
//    "PersonId": 12,
//    "Name": "Deepak",
//    "Address": "Bangal"
//  }
//]