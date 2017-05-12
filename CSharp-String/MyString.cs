using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_String
{
    public static class MyString
    {
        public static int StringToInt(string str)
        {
            var sum = 0;
            var zeroAscii = (byte)'0';
            var chrs = str.ToCharArray();

            for (int i = 0; i < chrs.Length; i++)
            {
                sum *= 10;
                sum += (((byte)chrs[i]) - zeroAscii);
            }

            return sum;
        }


        public static string IntToString(int number)
        {
            var zeroAscii = (byte)'0';
            Stack<char> chrs = new Stack<char>();
            
            while (number > 0)
            {
                var cur = (number % 10);
                number = (number / 10);
                chrs.Push((char)(cur + zeroAscii));
            }

            var s = new char[chrs.Count];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = chrs.Pop();
            }
            
            return new String(s);            
        }
    }
}
