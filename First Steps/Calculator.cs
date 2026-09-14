namespace First_Steps
{
    internal class Calculator
    {
        public static void Run() {
            //Enter a number please: 
            int yourNumber;

            while (true)
            {
                Console.WriteLine("Please enter a number:");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out yourNumber))
                {
                    break;
                }

                Console.WriteLine("Invalid number. Try again.");
            }

            Console.WriteLine($"The number you entered is: {yourNumber}");
        }
    }
}
