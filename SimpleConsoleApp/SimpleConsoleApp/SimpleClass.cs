using System;

namespace SimpleConsoleApp
{
    public class SimpleClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public SimpleClass()
        {
            Country = "Unitied Kingdom";
        }

        public string Concat(string _first, string _last)
        {
            return _first + " " + _last;
        }

        public void GetUsersName()
        {
            Console.WriteLine("Please enter your first name");

            FirstName = Console.ReadLine();

            Console.WriteLine("Please enter you last name");

            LastName = Console.ReadLine();
        }

        public void GetUsersIntValue()
        {
            Console.WriteLine("Please enter a number value");

            int input;

            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Error must be a number");
                Console.ReadLine();
            }

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Hello World " + i);
            }

            Console.ReadLine();
        }

        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }
    }
}