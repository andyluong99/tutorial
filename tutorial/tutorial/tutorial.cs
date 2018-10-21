using System;
namespace Tutorial
{
    class Tutorial
    {
        static void Main()
        {
            String yourName = "";

            Console.WriteLine("Hello World!\n");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();

            Console.WriteLine("Your name is " + yourName);
        }
    }
}