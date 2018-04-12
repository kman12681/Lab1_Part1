using System;

namespace L1_P1
{
    class Program
    {
        static void Main(string[] args)

        {
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

                string num1;

                while (true)
                {
                    while (true) // program won't continue until three digits entered
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a three digit number:");
                        Console.WriteLine();
                        num1 = Console.ReadLine();
                        int firstNumber;
                        bool num1Bool = Int32.TryParse(num1, out firstNumber);

                        // Input Validation

                        if (num1.Length == 3 && num1Bool)
                            break;
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Not a three digit number.");
                        }
                    }

                    // Second Input 

                    string num2;

                    while (true) // won't continue until three digits entered
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter another three digit number.");
                        Console.WriteLine();
                        num2 = Console.ReadLine();
                        int secondNumber;
                        bool num2Bool = Int32.TryParse(num2, out secondNumber);

                        // Input Validation

                        if (num2.Length == 3 && num2Bool)
                            break;

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Not three digits.");
                        }
                    }
                    
                    // calling Task method

                    Task(num1, num2);
                
                    while (true) // will run program again if user enters "Y"

                    {

                        Console.WriteLine("Enter Y to try again");
                        string input = Console.ReadLine().ToUpper();

                    if (input == "Y")
                        break;
                    
                    else

                    {
                        Console.WriteLine();
                        Console.WriteLine("Not a valid entry.");
                        Console.WriteLine();
                    }

                }

            }
        }
        
        // method to compare indexes

        static void Task(string num1, string num2)

        {
            int a = num1[0] + num2[0];
            int b = num1[1] + num2[1];
            int c = num1[2] + num2[2];

                    
            if (a == b && b == c)

            {
                Console.WriteLine();
                Console.WriteLine("True");
                Console.WriteLine();
            }

            else

            {
                Console.WriteLine();
                Console.WriteLine("False");
                Console.WriteLine();
            }


        }
    }
}
                                               





