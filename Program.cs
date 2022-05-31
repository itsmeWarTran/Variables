using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Warren";
            int age = 14;
            char firstLetter = 'W';
            bool lovesSwimming = true;
            double height = 5.6;
            decimal width = 5.32m;

            Console.WriteLine("{0} is {1} years old and is {2} tall. His width is {5}.The first letter in his name is a {3}. Does Warren love swimming? The answer to that is {4}." , name, age, height, firstLetter, lovesSwimming, width);
        }
    }
}
