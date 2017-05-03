using System;

namespace CSharp_Array
{
    partial class Program
    {
        public class Array
        {            
            private enum IsRepeat
            {
                Never,
                Once,
                Many
            }

            public static char FindFirstNonRepeat(char[] arr)
            {
                var lkup = new IsRepeat[256];

                foreach (char c in arr)
                {
                    var idx = ((int)c);
                    if (lkup[idx] == IsRepeat.Never)
                    {
                        lkup[idx] = IsRepeat.Once;
                    }
                    else
                    {
                        lkup[idx] = IsRepeat.Many;
                    }
                }

                foreach (char c in arr)
                {
                    if (lkup[((int)c)] == IsRepeat.Once)
                    {
                        return c;
                    }
                }

                throw new Exception("not found");
            }
        }
    }
}
