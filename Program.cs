using System;

namespace ConsoleCalculator
// this will subtract the two numbers

    class Program
{
    static void Main(string[] args)
    {
        bool exitProgram = false;

        Console.WriteLine(" My Calculator in C#");
        Console.WriteLine("------------------------");

        while (!exitProgram)
        {
            // Get the first number
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Get the operation
            Console.Write("Enter operation (+, -, *, /, %): ");
            string operation = Console.ReadLine();

            // Get the second number
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            try
            {
                // Perform calculation
                double result = CalculateResult(num1, operation, num2);

                // Display result
                DisplayResult(num1, operation, num2, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Ask if user wants to continue
            exitProgram = !ContinueCalculation();
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the calculator, I'm Vincent Villas, I'm the creator of this calculator!");
    }


    /// Calculates the result based on the given operation

    static double CalculateResult(double num1, string operation, double num2)
    {
        switch (operation)
        {
            case "+":
                return Add(num1, num2);
            case "-":
                return Subtract(num1, num2);
            case "*":
                return Multiply(num1, num2);
            case "/":
                return Divide(num1, num2);
            case "%":
                return Modulo(num1, num2);
            default:
                throw new ArgumentException("Invalid operation. Please use +, -, *, /, or %.");
        }
    }

    //here should be the functions to be put together
}
   
}