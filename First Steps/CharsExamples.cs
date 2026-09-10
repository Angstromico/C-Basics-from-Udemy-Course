namespace First_Steps
{
    internal class CharsExamples
    {
        /// <summary>
        /// Demonstrates different ways to create and work with characters,
        /// strings, and character arrays.
        /// </summary>
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

        /// <summary>
        /// Prints information about a single character, including its
        /// numeric value and neighboring characters.
        /// </summary>
        /// <param name="myChar">The character to analyze.</param>
        private static void PrintCharInfo(char myChar)
        {
            Console.WriteLine("The character is: " + myChar);
            Console.WriteLine("The ASCII value of the character is: " + (int)myChar);
            Console.WriteLine("The Unicode value of the character is: " + (int)myChar);
            Console.WriteLine("The character after incrementing is: " + (char)(myChar + 1));
            Console.WriteLine("The character after decrementing is: " + (char)(myChar - 1));
        }

        /// <summary>
        /// Iterates through each character in a string and prints
        /// information about each one.
        /// </summary>
        /// <param name="myString">The string whose characters will be analyzed.</param>
        private static void PrintCharInfo(string myString)
        {
            foreach (char c in myString)
            {
                PrintCharInfo(c);
            }

        }

        /// <summary>
        /// Iterates through a character array and prints information
        /// about each character.
        /// </summary>
        /// <param name="myCharArray">The array of characters to analyze.</param>
        private static void PrintCharInfo(char[] myCharArray)
        {
            foreach (char c in myCharArray)
            {
                PrintCharInfo(c);
            }
        }
    }
}
