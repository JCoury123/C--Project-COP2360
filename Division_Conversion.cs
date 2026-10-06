using System;

class Program
{
    static void Main(string[] args)
    {
        // Controls whether the program continues running
        bool keepRunning = true;

        while (keepRunning)
        {
            // Get two numbers from the user
            Console.WriteLine("\nEnter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            try
            {
                // Convert the user input from strings to integers
                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);

                // Divide the two numbers
                int result = Divide(number1, number2);

                Console.WriteLine($"\nThe result of {number1} divided by {number2} is: {result}");
            }
            catch (FormatException ex)
            {
                // Handles input that is not a valid number
                Console.WriteLine("\nError: Please enter valid whole numbers.");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                // Handles attempts to divide by zero
                Console.WriteLine("\nError: You cannot divide a number by zero.");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                // Handles numbers outside the range of an integer
                Console.WriteLine("\nError: The number entered is too large or too small.");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handles any other unexpected errors
                Console.WriteLine("\nAn unexpected error occurred.");
                Console.WriteLine($"Detailed error message: {ex.Message}");
            }

            // Ask the user if they want to run the program again
            Console.WriteLine("\nWould you like to enter more numbers? (Y/N)");
            string choice = Console.ReadLine();

            if (choice.ToUpper() != "Y")
            {
                keepRunning = false;
            }
        }

        Console.WriteLine("\nProgram ended.");
    }

    // Method used to divide the two integers
    static int Divide(int a, int b)
    {
        return a / b;
    }
}