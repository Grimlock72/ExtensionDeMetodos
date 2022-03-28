using System;

namespace ExtensionDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World!".Map());
            Console.ReadKey();
        }
    }

    public static class StringExtensions
    {
        public static string Map(this string T) // this. Para indicarle al compilador qué tipo va a extender.
        {
            char firstLetter = char.ToUpper(T[0]);
            string restPhrase = T.Substring(0);
            return firstLetter + "\n\r" + restPhrase;
        }
    }
}
