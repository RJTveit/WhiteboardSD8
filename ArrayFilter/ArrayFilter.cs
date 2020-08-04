using System;
using System.Globalization;
using System.Security.Cryptography;

namespace ArrayFilter
{
    public class DistinctArrayFilter
    {
        static int[] numbers = {8, 6, 7, 5, 3, 0, 9};

        public static int DistinctInteger(int[] numbers)
        {
            int count = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                int j = 0;
                for ( j = 0; j < i; j++)
                
                    if (numbers[i] == numbers[j])
                        break;

                    if (i == j)
                        count++;
                
            }
            return count;
        }
    }
}
