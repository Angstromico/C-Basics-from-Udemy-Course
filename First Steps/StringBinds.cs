namespace First_Steps
{
    internal class StringBinds
    {
        public static void Run()
        {
            // Interpolation
            string name = "Alice";
            int age = 30;
            string greeting = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(greeting);

            // Concatenation
            string ageString = "30";
            string greeting2 = "Hello, my name is " + name + " and I am " + ageString + " years old.";
            Console.WriteLine(greeting2);

            // Formating 
            int num = 42;
            double price = 19.99;
            string template = "The number is {0} and the price is {1}";
            string result = string.Format(template, num, price);
            Console.WriteLine(result);
        }
    }
}
