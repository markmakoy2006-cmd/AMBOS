using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMBOS__Inserting_Nodes_with_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MARK G. AMBOS IT402P DASTRU
            LinkedList<string> namesList = new LinkedList<string>();
            int numberOfNames = 0;

            // Exception handling for number of names
            while (true)
            {
                try
                {
                    Console.Write("How many names will you input?: ");
                    numberOfNames = int.Parse(Console.ReadLine());

                    if (numberOfNames <= 0)
                    {
                        Console.WriteLine("Enter a positive number.\n");
                        continue;
                    }
                    break; // valid input
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value.\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too large! Please enter a smaller value.\n");
                }
            }

            // Input names (user input only)
            for (int i = 1; i <= numberOfNames; i++)
            {
                Console.Write($"Friend #{i}: ");
                string name = Console.ReadLine();
                namesList.AddLast(name);
            }

            // Convert linked list to array for sorting
            string[] namesArray = new string[namesList.Count];
            namesList.CopyTo(namesArray, 0);
            Array.Sort(namesArray);

            // Display linked list (unsorted)
            Console.WriteLine("\nNames in linked list (unsorted):");
            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }

            // Display sorted names
            Console.WriteLine("\nNames sorted alphabetically:");
            foreach (string name in namesArray)
            {
                Console.WriteLine(name);
            }
        }
    }
}
