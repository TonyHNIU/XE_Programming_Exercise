using System;

namespace XE_Programming_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryagain = true;

            while (tryagain)
            {
                Console.WriteLine("Please enter the items!");
                var terminalService = Startup.Init();
                terminalService.SetPrice();
                Console.WriteLine("Available Products are: A, B, C, D");
                var input = System.Console.ReadLine();
                terminalService.Scan(input);
                var total = terminalService.CalculateTotal();
                Console.WriteLine("Total Price:" + total);
                tryagain = CanContinue();
            }
            Environment.Exit(0);
        }

        public static bool CanContinue()
        {
            Console.WriteLine("Enter Y to continue...");
            String contiue = Console.ReadLine();
            return String.Compare(contiue, "Y", true) == 0;
        }
    }
}
