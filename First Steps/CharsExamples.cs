namespace First_Steps
{
    internal class CharsExamples
    {
        public static void Run()
        {
            PrintCharInfo('A');
            PrintCharInfo("Hello");
            PrintCharInfo(new char[] { 'H', 'e', 'l', 'l', 'o' });

            char[] chars = new[] {
                'j',
                '\u006A',
                '\x006A',
                 (char)106,
            };
            PrintCharInfo(chars);
        }

        private static void PrintCharInfo(char myChar)
        {
            Console.WriteLine("The character is: " + myChar);
            Console.WriteLine("The ASCII value of the character is: " + (int)myChar);
            Console.WriteLine("The Unicode value of the character is: " + (int)myChar);
            Console.WriteLine("The character after incrementing is: " + (char)(myChar + 1));
            Console.WriteLine("The character after decrementing is: " + (char)(myChar - 1));
        }

        private static void PrintCharInfo(string myString)
        {
            foreach (char c in myString)
            {
                PrintCharInfo(c);
            }

        }

        private static void PrintCharInfo(char[] myCharArray)
        {
            foreach (char c in myCharArray)
            {
                PrintCharInfo(c);
            }
        }
    }
}
