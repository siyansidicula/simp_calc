using System;

namespace SimpleCalculator
{
    class Calculator
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is NOT POSSIBLE.");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            bool runCalculator = true;

            while (runCalculator)
            {
                Console.WriteLine("\n===== SIMPLE CALCULATOR =====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    runCalculator = false;
                    Console.WriteLine("Exiting Menu....");
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Add(num1, num2);
                        break;
                    case 2:
                        result = Subtract(num1, num2);
                        break;
                    case 3:
                        result = Multiply(num1, num2);
                        break;
                    case 4:
                        result = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                Console.WriteLine("Result: " + result);
            }
        }
    }
}