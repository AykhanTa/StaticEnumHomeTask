using System.Text.RegularExpressions;

namespace StaticEnumHomeTask.Extensions
{
    internal static class Extension
    {
        public static void Factorial(this int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;    
            }
            Console.WriteLine(result);            
        }

        public static void MatchCount(this string sentence, string word)
        {
            Console.WriteLine(Regex.Count(sentence, word));
        } 
    }
}
