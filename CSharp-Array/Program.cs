using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Array
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var arr = "total".ToArray();            
            //var c = Array.FindFirstNonRepeat(arr);

            //var c  =Array.RemoveChars("Battle of the Vowels: Hawaii vs. Grozny", "aeiou");
            //var c = Array.ReverseWord("word".ToArray());
            var c = Array.ReverseWords("de blah back".ToCharArray());

            Console.WriteLine(c);

            //Console.WriteLine(arr);

            Console.ReadKey();
        }
    }
}
