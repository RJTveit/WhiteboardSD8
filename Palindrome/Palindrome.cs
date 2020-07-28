using System;

namespace Palindrome
{
    public class Palindrome
    {
        public static bool IsPalindrome( string inputString )
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                char last = char.ToUpper(inputString[inputString.Length - i - 1]);
                char first = char.ToUpper(inputString[i]);
                if (first != last) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome.Program.Main()");
        }
    }
}
