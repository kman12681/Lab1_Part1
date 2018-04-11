using System;

namespace L1_P1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome User

            Console.WriteLine("Hello, this program will assess whether the individual digits in two numbers all add to the same value.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.WriteLine("The console will read 'True' if the digits add to the same value, and 'False' if they do not.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            // First Input

            First:
            Console.WriteLine("Please enter a three digit number:");
            string num1 = Console.ReadLine();
            int len1 = num1.Length;

            // Input Validation

            if (len1 != 3)
            {
                Console.WriteLine("Not a three digit number.");
                goto First;
            }
            
            // Second Input 

            Second:
            Console.WriteLine("Enter another three digit number.");
            string num2 = Console.ReadLine();
            int len2 = num2.Length;

            // Input Validation

            if (len2 != 3)
            {
                Console.WriteLine("Not three digits.");
                goto Second;
            }

            // Assigning variables to indexes

                int a = num1[0];
                int b = num1[1];
                int c = num1[2];
         
                int q = num2[0];
                int r = num2[1];
                int s = num2[2];
           
                // Comparing indexes between num1 and num2

                    if (((a + q) == (b + r)) && ((b + r) == (c + s))) 

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
                                               





/*for (int a = 0; a<num1.Length; a++)
       { for (int b = 0; b<num2.Length; b++)

           if (num1[a] == num2[b])
           {

               Console.WriteLine("True");
           }
           else
           {
               Console.WriteLine("False");
           }
       }*/
