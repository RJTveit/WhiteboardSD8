using System;

namespace ReverseString
{
    public class StringMirror
    {
        public static string ReverseString( string inputString )
        {
            string outputString = "";
            for( int i = inputString.Length; i>0;  )
            {
                outputString += inputString[--i];
            }
            return outputString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ReverseString.Program.Main()");

            string myString = "TestString";
            Console.WriteLine($"{myString} <> {ReverseString(myString)}");
        }
    }
}
