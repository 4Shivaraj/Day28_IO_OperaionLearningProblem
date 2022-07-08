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

                default:
                    break;
            }

        }

    }
}

//Jason DeSerialisation
//In Console

//Result:
//Welcome To IO Learning Problems
//1 for Jason Serialise
//2 for Jason Deserialise
//2
//File Exists
//Id:12   Name: Shivaraj Address: Delhi
//Id:13   Name: Arun Address: Bangalore
//Id:12   Name: Deepak Address: Bangal