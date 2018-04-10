using System;


namespace StringValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program will assess whether the digits in each corresponding place between two numbers add to the same value.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.WriteLine("The console will read 'True' if the digits add to the same value, and 'False' if they do not.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.WriteLine("Enter a three digit number: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Now enter another three digit number: ");
            string num2 = Console.ReadLine();

            int a = num1[0];
            int b = num1[1];
            int c = num1[2];

            int x = num2[0];
            int y = num2[1];
            int z = num2[2];

            if (((a + x) == (b + y)) && ((b + y) == (c + z)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();

        }
    }
}