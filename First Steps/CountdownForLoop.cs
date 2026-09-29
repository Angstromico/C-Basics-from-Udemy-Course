namespace First_Steps
{
    internal class CountdownForLoop
    {
        public static void Run()
        {
            Console.WriteLine("Countdown from 10 to 1:");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); // Pause for 1 second between numbers
            }
            Console.WriteLine("Liftoff!");
        }
    }
}
