namespace First_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            //Message
            Console.WriteLine("Please enter a message: ");
            string? userMessage = Console.ReadLine();
            Console.WriteLine("You entered: " + userMessage);
            
            CharsExamples.Run();
            Calculator.Run();
            Conversions.Run();

            Console.ReadKey();
        }
    }
}