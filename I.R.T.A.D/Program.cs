using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.R.T.A.D
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = ChooseProgram();

            while (command.ToLower() != "exit")
            {
                switch (command.ToLower())
                {
                    case "reverseint":

                        var input = "";

                        while (input.ToLower() != "back")
                        {
                            Console.WriteLine("Enter 'back' to return to application select':");
                            Console.WriteLine("Enter Input:");
                            input = Console.ReadLine();
                            var result = ReverseInt.Run(Convert.ToInt32(input));
                            Console.WriteLine(result);
                            Console.WriteLine("Press any key to continue. . .");
                            if (Console.ReadKey() != null)
                            {
                                Clear();
                            }
                        }

                        command = ChooseProgram();

                        break;
                    default:
                        Console.WriteLine("Type 'exit' to close the program.");
                        command = Console.ReadLine();
                        break;
                }
            }
        }

        public static string ChooseProgram()
        {
            //Get Application List
            var ListOfApplications = ApplicationList();
            foreach (var item in ListOfApplications)
            {
                Console.WriteLine($"{item.id}. {item.Name}");
            }
            Console.WriteLine();
            Console.WriteLine("Enter the program name you wish to run OR 'exit' to close the program:");
            return Console.ReadLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static List<Application> ApplicationList()
        {
            List<Application> newList = new List<Application>();

            Application item = new Application { id = 1, Name = "reverseint" };
            newList.Add(item);

            return newList;
        }

        public class Application
        {
            public int id { get; set; }
            public string Name { get; set; }
        }
    }
}
