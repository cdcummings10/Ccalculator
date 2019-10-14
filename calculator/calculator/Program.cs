using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calcOn = true;
            Console.WriteLine("Welcome to this C# Calculator!");
            // Will keep runnning calculator until exit is called in menu
            while (calcOn)
            {
                DisplayMenu();
                //Receiving user choice
                string choice = Console.ReadLine();
            
                if (choice == "1")
                {
                    Console.WriteLine("Answer: {0}", Addition(SaveFirstInput(), SaveSecondInput()));
                }
                else if (choice == "2") 
                {
                    Console.WriteLine("Answer: {0}", Subtraction(SaveFirstInput(), SaveSecondInput()));
                }
                else if (choice == "3") 
                {
                    Console.WriteLine("Answer: {0}", Multiplication(SaveFirstInput(), SaveSecondInput()));
                }
                else if (choice == "4") 
                {
                    Console.WriteLine("Answer: {0}", Division(SaveFirstInput(), SaveSecondInput()));
                }
                else if (choice == "5") 
                    { 
                    //Exit Loop
                    Console.WriteLine("Thanks for using the calculator!");
                    calcOn = false;
                    }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

            }

            Console.ReadLine();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Choose your mathematical operation:");
            Console.WriteLine("1) Addtion");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
        }

        //Receiving inputs
        private static decimal SaveFirstInput()
        {
            Console.WriteLine("Input First Number");
            return Decimal.Parse(Console.ReadLine());
        }
        private static decimal SaveSecondInput()
        {
            Console.WriteLine("Input Second Number");
            return Decimal.Parse(Console.ReadLine());
        }

        // Math operations
        private static decimal Addition(decimal input1, decimal input2)
        {
            return input1 + input2;
        }
        private static decimal Subtraction(decimal input1, decimal input2)
        {
            return input1 - input2;
        }
        private static decimal Multiplication(decimal input1, decimal input2)
        {
            return input1 * input2;
        }
        private static decimal Division(decimal input1, decimal input2)
        {
            return input1 / input2;
        }
    }
}
