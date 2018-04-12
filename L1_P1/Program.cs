using System;

namespace L1_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of digits requested from user
            
            string digits = "ten";
            int digitsCount = 10;

            // Welcome User

            Console.WriteLine();
            Console.WriteLine("Hello, this program will assess whether the individual digits in two numbers all add to the same value.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("The console will read 'True' if the digits add to the same value, and 'False' if they do not.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            // First Input

            First:
            Console.WriteLine();
            Console.WriteLine("Please enter a " + digits + " digit number:");
            Console.WriteLine();
            string num1 = Console.ReadLine();
            int len1 = num1.Length;

            // Input Validation

            if (len1 != digitsCount)
            {
                Console.WriteLine();
                Console.WriteLine("Not a " + digits + " digit number.");
                goto First;
            }
            
            // Second Input 

            Second:
            Console.WriteLine();
            Console.WriteLine("Enter another " + digits + " digit number.");
            Console.WriteLine();
            string num2 = Console.ReadLine();
            int len2 = num2.Length;

            // Input Validation

            if (len2 != digitsCount)
            {
                Console.WriteLine();
                Console.WriteLine("Not " + digits + " digits.");
                goto Second;
            }

            // Assigning variables to indexes                                              
            
                int a = num1[0] + num2[0];
                int b = num1[1] + num2[1];
                int c = num1[2] + num2[2];
                int d = num1[3] + num2[3];
                int e = num1[4] + num2[4];
                int f = num1[5] + num2[5];
                int g = num1[6] + num2[6];
                int h = num1[7] + num2[7];
                int i = num1[8] + num2[8];
                int j = num1[9] + num2[9];          
                                                          
           // Comparing indexes between num1 and num2

           if (a == b && b == c && c ==d && d == e && e == f &&
                f == g && g == h && h == i && i == j) 

                    {
                        Console.WriteLine();                
                        Console.WriteLine("True");
                    }

                    else

                    {
                        Console.WriteLine();
                        Console.WriteLine("False");
                    }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to try again.");
            Console.ReadKey(true);
            Console.WriteLine();
            goto First;

        }
    }
}
                                               





