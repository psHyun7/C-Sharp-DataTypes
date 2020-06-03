using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.5.1 Input / Output
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            System.Console.WriteLine("Hello, " + name);

            // 2.5.2 Numeric Type
            System.Console.WriteLine("What is the dimension of the Rectangle?");
            Console.WriteLine("Length:");
            float length = float.Parse(System.Console.ReadLine());
            Console.WriteLine("Width:");
            float width = float.Parse(Console.ReadLine());

            float area = length * width;
            Console.WriteLine("The Area of the Rectangle is " + area.ToString() + ".");

            // 2.5.3 More on Numeric Types
            Console.WriteLine("How many Miles have you driven?:");
            float miles = float.Parse(Console.ReadLine());
            Console.WriteLine("How many Gallons of gas did you use?:");
            float galOfGas = float.Parse(Console.ReadLine());
            float mpg = miles / galOfGas;
            Console.WriteLine("Your miles-per-gallon (MPG) is " + mpg.ToString() + ".");

            // 2.5.4 Strings
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'";
            System.Console.WriteLine("What term do you want to search for?:");
            string searchTerm = System.Console.ReadLine();
            string aliceUpper = alice.ToUpper();
            string searchTermUpper = searchTerm.ToUpper();

            int index = aliceUpper.IndexOf(searchTermUpper);
            if (index >= 0)
            {
                Console.Write("True\n");
                Console.Write("Index of searchterm " + searchTerm + " is " + index.ToString() + ".\n");
                Console.Write("It has the Length of " + searchTerm.Length + ".\n\n");
                string newAliceFront = alice.Substring(0, index - 1);
                string newAliceBack = alice.Substring(index + searchTerm.Length, 
                    alice.Length - newAliceFront.Length - searchTerm.Length - 1);
                string newAlice = newAliceFront + newAliceBack;
                System.Console.Write(newAlice + "\n");
            }
            else
            {
                Console.Write("False");
            }
        }
    }
}
