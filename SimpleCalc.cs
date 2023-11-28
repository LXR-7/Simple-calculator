using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            int choice;

            // Check if the input is a valid integer
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                Console.Write("Enter your choice (1-5): ");
            }

            if (choice == 5)
            {
                Console.WriteLine("Exiting the calculator.");
                break;
            }

            Console.Write("Enter the first number: ");
            double num1;

            // Check if the input is a valid double
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the first number: ");
            }

            Console.Write("Enter the second number: ");
            double num2;

            // Check if the input is a valid double
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the second number: ");
            }

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        continue; // Skip further processing and restart the loop
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue; // Skip further processing and restart the loop
            }

            Console.WriteLine($"Result: {result}");

            // Ask the user if they want to continue
            Console.Write("Do you want to continue? (y/n): ");
            string continueInput = Console.ReadLine();

            if (continueInput.ToLower() != "y")
            {
                Console.WriteLine("Exiting the calculator.");
                break;
            }
        }
    }
}