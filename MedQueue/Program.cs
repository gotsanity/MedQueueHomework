using System;

namespace MedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ERQueue queue = new ERQueue();

            bool exitMenu = false;

            while (!exitMenu)
            {
                PrintMenu();
                string choice = Console.ReadLine().ToLower();
                
                switch (choice)
                {
                    case "a":
                        Add(queue);
                        break;
                    case "p":
                        Remove(queue);
                        break;
                    case "l":
                        List(queue);
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

        static void Add(ERQueue queue)
        {
            Console.WriteLine("What is the patient's name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the patient's priority?");
            int priority = Convert.ToInt32(Console.ReadLine());

            int result = queue.Enqueue(new Patient(name, priority));
            if (result == -1)
            {
                Console.WriteLine("Queue was full");
            }
        }

        static void Remove(ERQueue queue)
        {
            Patient patient = queue.Dequeue();
            if (patient == null)
            {
                Console.WriteLine("There are no more patients in the queue.");
            }
            else
            {
                Console.WriteLine("Processing patient: {0} with a priority of {1}", patient.Name, patient.Priority);
            }
        }

        static void List(ERQueue queue)
        {
            if (queue.IsEmpty())
            {
                Console.WriteLine("No Patients in the queue");
            }
            else
            {
                Console.WriteLine("Listing all Patients");
                Console.Write(queue.ToString());
            }
        }
    }
}
