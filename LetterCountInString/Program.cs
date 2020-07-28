using System;

namespace LetterCountInString
{
    class Program
    {
        // 3 - 'S's
        // given: Name of Movie and character to search for.
        // return how many of the given character are needed?

        public static int LetterCountInString(string title, char searchCharacter)
        {
            int letterCount = 0;

            searchCharacter = char.ToLower(searchCharacter);
            title = title.ToLower();

            for (int i = 0; i < title.Length; i++)
            {
                if (title[i] == searchCharacter)
                {
                    letterCount++;
                }
            }

            return letterCount;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Program.LetterCountInString()");

            string movieTitle = "Shawshank Redemption";
            char searchLetter = 'S';
            int count = LetterCountInString( movieTitle, searchLetter);

            Console.WriteLine($"There are {count} {searchLetter} in {movieTitle}" );
        }
    }
}
