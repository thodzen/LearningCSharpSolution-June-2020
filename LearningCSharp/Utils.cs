using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCSharp.Utilities
{
    // Have to be a :
    // - static method
    // - in a static class
    // - and have the 'this' keyword on the first argument
    public static class Utils
    {
        // using 'this' before the params allow you to call the method on
        // itself without passing it in
        public static bool IsEven(this int x)
        {
            return x % 2 == 0;
        }

        public static DateTime DaysFromToday(this int days)
        {
            return DateTime.Now.AddDays(days);
        }

        public static int CountVowels(this string phrase)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            return phrase
                .Where(vowels.Contains)
                .Count();
        }
    }
}
