// See https://aka.ms/new-console-template for more information
using System;
using HelloWorldLibrary; // Reference to the .NET Standard library

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a username as a command line argument.");
                return;
            }

            string username = args[0];
            string message = HelloWorldHelper.GetGreetingMessage(username);
            Console.WriteLine(message);
        }
    }
}
