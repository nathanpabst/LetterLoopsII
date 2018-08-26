using System;
using System.Linq;

namespace LetterLoopsII
{
    class Program
    {
        static void Main(string[] args)
            //INPUT = RqaEzty OUTPUT = R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy
        {
            var input = "RqaEzty";
            Console.WriteLine($"The original input was: {input}");
            //string.Join() method concatenates the results with a dash between each element
            //The Select extension method with 'c' and 'i' parameters returns an uppercase version of the character followed by a string of lowercase characters in the length of the index.
            var modifiedInput = string.Join("-", input.Select((c, i) => Char.ToUpper(c) + new string(Char.ToLower(c), i)));
            Console.WriteLine($"The modified input is: {modifiedInput}");

            Console.WriteLine("press enter to exit.");
            Console.ReadLine();
        }
    }
}
