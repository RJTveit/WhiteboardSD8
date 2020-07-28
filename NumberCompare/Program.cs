using System;


namespace NumberCompare
{
    public class Program
    {
        public static string NumberCompare(int A, int B)
        {
            if (A > B)
            {
                return $"{A} > {B}";
            }
            return $"{B} > {A}";
        }
        public static string NumberCompare( double A, double B)
        {
            if (A > B)
            {
                return $"{A} > {B}";
            }
            return $"{B} > {A}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("NumberCompare.Program.Main()");

            //var A = 27.1;
            //var B = 30.5;
            //var x = 'A';
            //var y = 17.0/5;
            //y = Math.PI;
            //Console.WriteLine(NumberCompare(A,B));
            //Console.WriteLine(NumberCompare(x,y));
            //Console.WriteLine(NumberCompare(x,B));
        }
    }
}
