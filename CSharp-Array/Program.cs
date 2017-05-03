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
            var arr = "total".ToArray();            
            var c = Array.FindFirstNonRepeat(arr);

            Console.WriteLine(c);

            Console.WriteLine(arr);



            Console.ReadKey();
        }
    }
}
