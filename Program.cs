using System;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program sorts objects using List.");

        START:
        Console.WriteLine("\n------------------------------------");

        Console.WriteLine("Do you want to sort strings or numbers? (strings, numbers)");
        string choice = Console.ReadLine().ToLower();

        if (choice == "numbers")
        {
            Console.WriteLine("How many numbers do you want to sort?");
            int n = Convert.ToInt32(Console.ReadLine());

            List <float> numbers = new List<float>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} number: ", i + 1);
                float num = float.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            Console.WriteLine("List before Sorting");
            
            bool first = true;
            foreach (float num in numbers)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(num);
                first = false;
            }
            
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("List Sorted in Ascending Order.");

            numbers.Sort();

            first = true;
            foreach (float num in numbers)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(num);
                first = false;
            }

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("List Sorted in Descending Order.");

            numbers.Reverse();

            first = true;
            foreach (float num in numbers)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(num);
                first = false;
            }
        }
        else if (choice == "strings")
        {
            Console.WriteLine("How many strings do you want to sort?");
            int n = Convert.ToInt32(Console.ReadLine());

            List <string> strings = new List<string>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0} string: ", i + 1);
                string str = Console.ReadLine();
                strings.Add(str);
            }

            Console.WriteLine("List before Sorting");
            
            bool first = true;
            foreach (string str in strings)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(str);
                first = false;
            }
            
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("List Sorted in Ascending Order.");

            strings.Sort();

            first = true;
            foreach (string str in strings)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(str);
                first = false;
            }

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("List Sorted in Descending Order.");

            strings.Reverse();

            first = true;
            foreach (string str in strings)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(str);
                first = false;
            }
        }
        else
        {
            Console.WriteLine("Wrong Choice! Please Try Again!");
            goto START;
        }
    }
}