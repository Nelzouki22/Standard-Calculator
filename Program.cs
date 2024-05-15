using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine($"Result: {result}");

            Console.ReadLine();
        }
    }
}
