

namespace First_Steps
{
    internal class ReferencesEquals
    {
        public static void Run()
        {
            string str1 = "Hello";
            string str2 = "Hello";
            string str3 = new string("Hello".ToCharArray());
            Console.WriteLine($"str1 == str2: {str1 == str2}"); // True, same value
            Console.WriteLine($"ReferenceEquals(str1, str2): {ReferenceEquals(str1, str2)}"); // True, same reference
            Console.WriteLine($"str1 == str3: {str1 == str3}"); // True, same value
            Console.WriteLine($"ReferenceEquals(str1, str3): {ReferenceEquals(str1, str3)}"); // False, different references
        }
    }
}
