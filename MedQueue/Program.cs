using System;

namespace MedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitMenu = false;

            while (!exitMenu)
            {
                PrintMenu();
                string choice = Console.ReadLine().ToLower();
                
                switch (choice)
                {
                    case "a":
                        AddPatient();
                        break;
                    case "p":
                        ProcessPatient();
                        break;
                    case "l":
                        List();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("(A)dd Patient  (P)rocess Current Patient  (L)ist All in Queue  (Q)uit");
        }

        static void AddPatient()
        {
            Console.WriteLine("Adding Patient");
        }

        static void ProcessPatient()
        {
            Console.WriteLine("Processing Patient");
        }

        static void List()
        {
            Console.WriteLine("Listing all Patients");
        }
    }
}
