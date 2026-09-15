namespace First_Steps
{
    internal class Conversions
    {
        public static void Run()
        {
            // Convert a string to an integer
            string numberString = "123";
            int number = int.Parse(numberString);
            Console.WriteLine($"Converted '{numberString}' to integer: {number}");
            // Convert a string to a double
            string doubleString = "123.45";
            double doubleNumber = double.Parse(doubleString);
            Console.WriteLine($"Converted '{doubleString}' to double: {doubleNumber}");
            // Convert an integer to a string
            int intValue = 456;
            string intToString = intValue.ToString();
            Console.WriteLine($"Converted integer {intValue} to string: '{intToString}'");
            // Convert a double to a string
            double doubleValue = 789.01;
            string doubleToString = doubleValue.ToString();
            Console.WriteLine($"Converted double {doubleValue} to string: '{doubleToString}'");

            //Implicit conversion
            int implicitInt = 10;
            double implicitDouble = implicitInt; // Implicit conversion from int to double
            Console.WriteLine($"Implicitly converted int {implicitInt} to double: {implicitDouble}");
            long implicitLong = implicitInt; // Implicit conversion from int to long
            Console.WriteLine($"Implicitly converted int {implicitInt} to long: {implicitLong}");
            float implicitFloat = implicitInt; // Implicit conversion from int to float
            Console.WriteLine($"Implicitly converted int {implicitInt} to float: {implicitFloat}");
            implicitDouble = implicitFloat; // Implicit conversion from float to double
            Console.WriteLine($"Implicitly converted float {implicitFloat} to double: {implicitDouble}");

            //Explicit conversions
            double explicitDouble = 123.45;
            int explicitInt = (int)explicitDouble; // Explicit conversion from double to int
            Console.WriteLine($"Explicitly converted double {explicitDouble} to int: {explicitInt}");

            // Method any string into number
            //<summary>
            // Extracts the numeric part from a string and converts it to an integer.
            // If the string does not contain any digits, it returns 0.
            //</summary>
            static int ExtractNumber(string input)
            {
                string digits = string.Concat(input.Where(char.IsDigit));

                return int.TryParse(digits, out int result)
                    ? result
                    : 0;
            }

            Console.WriteLine(ExtractNumber("123a"));   // 123
            Console.WriteLine(ExtractNumber("abc"));    // 0
            Console.WriteLine(ExtractNumber("a1b2c3")); // 123
            Console.WriteLine(ExtractNumber("7up"));    // 7

            // Convert Class
            string myBooleanString = "true";
            bool myBoolean = Convert.ToBoolean(myBooleanString);
            Console.WriteLine($"Converted string '{myBooleanString}' to boolean: {myBoolean}");
        }
    }
}
