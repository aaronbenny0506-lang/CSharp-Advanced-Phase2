using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool keepRunning = true;

            Console.WriteLine("=== Simple Calculator ===");

            // A loop keeps the calculator running until the user chooses to exit.
            while (keepRunning)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                    continue;
                }

                double num1 = ReadNumber("Enter the first number: ");
                double num2 = ReadNumber("Enter the second number: ");
                double result;

                try
                {
                    switch (choice)
                    {
                        case "1":
                            result = calculator.Add(num1, num2);
                            Console.WriteLine($"Result: {num1} + {num2} = {result}");
                            break;
                        case "2":
                            result = calculator.Subtract(num1, num2);
                            Console.WriteLine($"Result: {num1} - {num2} = {result}");
                            break;
                        case "3":
                            result = calculator.Multiply(num1, num2);
                            Console.WriteLine($"Result: {num1} * {num2} = {result}");
                            break;
                        case "4":
                            result = calculator.Divide(num1, num2);
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please pick 1-5.");
                            break;
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // A helper method that keeps asking until the user types a valid number.
        static double ReadNumber(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("That's not a valid number. Try again: ");
            }
            return number;
        }
    }
}
