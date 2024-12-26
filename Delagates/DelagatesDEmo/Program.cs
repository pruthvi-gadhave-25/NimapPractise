using System.Linq;

namespace DelagatesDEmo
{

    public class Program
    {
        public delegate void PrintMeasage(string msg);
        public delegate void MenuAction();
        public delegate void Calculate(int x, int y);


        public static void Main()
        {
            PrintMeasage printMsg = new PrintMeasage(BasicDelegate.PrintConsole);
            printMsg += BasicDelegate.PrintFileMsg;

            printMsg("Delagate Mulicast example ");
            Console.WriteLine();
            ////------------------------------------------------------------------------
            Dictionary<string, MenuAction> menu = new Dictionary<string, MenuAction>
        {
            { "1", MenuDelagate.ShowDate },
            { "2", MenuDelagate.ShowTime },
            { "3", MenuDelagate.Exit }
        };


            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Show Date");
                Console.WriteLine("2. Show Time");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (menu.ContainsKey(choice))
                {
                    menu[choice]();
                    if (choice == "3") break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            ////------------------------------------------------------------------------
            ///
            Console.WriteLine();

            Console.WriteLine("addition using delagte methods = "+ParametersDelagtes.Add(2, 3));
            Console.WriteLine("Multily using delagte methods = "+ParametersDelagtes.Multiply(2, 3));
        }
    }
}