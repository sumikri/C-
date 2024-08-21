using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}



using System;

namespace ExtensionsDemo
{
    public static class StringExtensions
    {
        // This extension method adds a method to reverse a string
        public static string ReverseString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class Program
    {
        static void Main()
        {
            string example = "Hello, World!";
            string reversed = example.ReverseString();
            Console.WriteLine(reversed);  // Output: !dlroW ,olleH
        }
    }
}
