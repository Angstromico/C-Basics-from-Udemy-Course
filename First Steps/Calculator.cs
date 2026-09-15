namespace First_Steps
{
    internal class Calculator
    {
        public static void Run() {
            //Sum of two input numbers: 
            double firstNumber = ReadNumber("Please enter a number:");
            double secondNumber = ReadNumber("Please enter a second number:");

            double sum = Math.Round(firstNumber + secondNumber, 2);

            Console.WriteLine($"The number you entered is: {firstNumber}");
            Console.WriteLine($"The second number you entered is: {secondNumber}");
            Console.WriteLine($"The sum of the two numbers is: {sum}");

            static double ReadNumber(string message)
            {
                while (true)
                {
                    Console.WriteLine(message);

                    string? input = Console.ReadLine();

                    if (double.TryParse(input, out double number))
                    {
                        return number;
                    }

                    Console.WriteLine("Invalid number. Try again.");
                }
            }
        }
    }
}
