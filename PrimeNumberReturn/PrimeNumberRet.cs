using System;

namespace PrimeNumberReturn
{
    public class PrimeNumberRet
    {
        public static bool IsPrimeNumber(int userInput)
        {
             for (int i = 2; i < userInput; i++)
             {
                if (userInput % i > 0) 
                {
                    return false;
                }  
                
             }

            return true;

        }

    }

}
