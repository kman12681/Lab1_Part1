using System;

namespace L1_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Please enter a number without decimals");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you just wrote contains this many digits: {0} ", GetDigits(x, 0));
            Console.ReadLine();

            Console.WriteLine("Now, please write another number (without decimals) with the same number of digits as the first number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you just wrote contains this many digits: {0} ", GetDigits(y, 0));
            Console.ReadLine();
        }

        private static int GetDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;

            return GetDigits(n1 / 10, ++nodigits);
        }
    }
}
