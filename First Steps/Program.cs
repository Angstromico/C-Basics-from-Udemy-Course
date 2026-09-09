namespace First_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a message: ");
            string userMessage = Console.ReadLine();
            Console.WriteLine("You entered: " + userMessage);
            Console.ReadKey();
        }
    }
}