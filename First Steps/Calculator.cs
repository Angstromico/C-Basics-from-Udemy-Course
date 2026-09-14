namespace First_Steps
{
    internal class Calculator
    {
        public static void Run() {
            //Sum of two input numbers: 
            int firstNumber = ReadNumber("Please enter a number:");
            int secondNumber = ReadNumber("Please enter a second number:");

            int sum = firstNumber + secondNumber;

            Console.WriteLine($"The number you entered is: {firstNumber}");
            Console.WriteLine($"The second number you entered is: {secondNumber}");
            Console.WriteLine($"The sum of the two numbers is: {sum}");

            static int ReadNumber(string message)
            {
                while (true)
                {
                    Console.WriteLine(message);

                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out int number))
                    {
                        return number;
                    }

                    Console.WriteLine("Invalid number. Try again.");
                }
            }
        }
    }
}
