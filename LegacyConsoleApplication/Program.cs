using System;
using BusinessLogicLayer;

namespace LegacyConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Greeter greeter = new Greeter();

            Console.Write("Enter the person ID, or 'q' to quit: ");

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "q")
                {
                    break;
                }

                int id;
                if (!int.TryParse(line, out id))
                {
                    Console.WriteLine("Invalid ID - Must be a number.");
                    Console.Write("Enter the person ID, or 'q' to quit: ");
                    continue;
                }

                // This is the important bit...
                string greeting = greeter.SayHello(id);

                Console.WriteLine(greeting);
                Console.Write("Enter the person ID, or 'q' to quit: ");
            }
        }
    }
}
