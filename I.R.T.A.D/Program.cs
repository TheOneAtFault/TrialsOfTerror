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
            var input = "";
            while (command.ToLower() != "exit")
            {
                switch (command.ToLower())
                {
                    case "reverseint":
                        input = "";

                        while (input.ToLower() != "back")
                        {
                            Console.WriteLine("Enter 'back' to return to application select");
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
                    case "palindromenum":
                        input = "";

                        while (input.ToLower() != "back")
                        {
                            Console.WriteLine("Enter 'back' to return to application select");
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
                    case "romantoint":
                        input = "";

                        while (input.ToLower() != "back")
                        {
                            Console.WriteLine("Enter 'back' to return to application select");
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
                    case "checkprefix":
                        input = "";

                        while (input.ToLower() != "back")
                        {
                            Console.WriteLine("Enter 'back' to return to application select");
                            Console.WriteLine("Enter Input seperated with a comma(,):");
                            input = Console.ReadLine();
                            var result = CheckPrefix.Run(input.Split(','));
                            Console.WriteLine(result);
                            Console.WriteLine("Press any key to continue. . .");
                            if (Console.ReadKey() != null)
                            {
                                Clear();
                            }
                        }

                        command = ChooseProgram();
                        break;
                    case "checkparentheses":
                        input = "";

                        while (input.ToLower() != "back")
                        {
                            Console.WriteLine("Enter 'back' to return to application select");
                            Console.WriteLine("Enter Input:");
                            input = Console.ReadLine();
                            var result = CheckParentheses.Run(input);
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
                        Clear();
                        command = ChooseProgram();
                        Console.WriteLine("No such program found. \nPlease select a program from the list. \n-Type 'exit' to close the program.");
                        command = Console.ReadLine();
                        break;
                }
            }
        }

        public static string ChooseProgram()
        {
            Console.WriteLine("Programs to choose from:");
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
            Application item2 = new Application { id = 2, Name = "palindromenum" };
            newList.Add(item2);
            Application item3 = new Application { id = 3, Name = "romantoint" };
            newList.Add(item3);
            Application item4 = new Application { id = 4, Name = "checkprefix" };
            newList.Add(item4);
            Application item5 = new Application { id = 5, Name = "checkparentheses" };
            newList.Add(item5);

            return newList;
        }

        public class Application
        {
            public int id { get; set; }
            public string Name { get; set; }
        }
    }
}
