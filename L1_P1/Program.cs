using System;

namespace SimpleSum
{
    class Program
    {
        static void Main(string[] args)
        {
        First:
            Console.WriteLine("Enter a positive three digit number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 999 || num1 < 000)
            {
                Console.WriteLine("This is not a positive three digit number");
                goto First;
            }

        Second:
            Console.WriteLine("Thank you, now enter another positive three digit number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 > 999 || num2 < 000)
            {
                Console.WriteLine("This is not a positive three digit number");
                goto Second;
            }

            int total = Sum(num1, num2);

            // exceptions to handle, when decimals are used, when numbers larger than ints are used
            // how to move the if statement to a second method

            if (total == 000 ||
                total == 111 ||
                total == 222 ||
                total == 333 ||
                total == 444 ||
                total == 555 ||
                total == 666 ||
                total == 777 ||
                total == 888 ||
                total == 999)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.Read();
        }
        public static int Sum(int x, int y)
        {
            int total = x + y;
            return total;
        }

    }
}