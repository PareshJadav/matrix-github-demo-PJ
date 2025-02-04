/// The main entry point for the Calculator program.
/// </summary>
/// 
using System;

class Program
{
    /// <summary>
    /// Prompts the user to enter two numbers and an operator, then performs the corresponding calculation.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        double result;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine($"The result is: {result}");
    }
}