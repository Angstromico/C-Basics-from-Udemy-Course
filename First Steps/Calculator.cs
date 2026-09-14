namespace First_Steps
{
    internal class Calculator
    {
        public static void Run() {
            //Sum of two input numbers: 
            int firstNUmber;
            int secondNumber;
            int firstAndSecondSum;

            while (true)
            {
                Console.WriteLine("Please enter a number:");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out firstNUmber))
                {
                    break;
                }

                Console.WriteLine("Invalid number. Try again.");
            }

            while (true)
            {
                Console.WriteLine("Please enter a second number:");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out secondNumber))
                {
                    break;
                }

                Console.WriteLine("Invalid number. Try again.");
            }

            firstAndSecondSum = firstNUmber + secondNumber;

            Console.WriteLine($"The number you entered is: {firstNUmber}");
            Console.WriteLine($"The second number you entered is: {secondNumber}");
            Console.WriteLine($"The sum of the two numbers is: {firstAndSecondSum}");
        }
    }
}
