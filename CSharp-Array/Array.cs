using System;
using System.Collections.Generic;

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

            public static string RemoveChars(string src, string remove)
            {
                var scrArr = src.ToCharArray();
                HashSet<char> hsRmv = new HashSet<char>(remove.ToCharArray());

                char tmp;
                int srcIdx = 0;
                int dstIdx = 0;
                while (true)
                {
                    if (srcIdx >= scrArr.Length)
                    {
                        System.Array.Resize(ref scrArr, dstIdx);
                        break;
                    }
                        
                    tmp = scrArr[srcIdx];
                    srcIdx++;

                    if (!hsRmv.Contains(tmp))
                    {
                        scrArr[dstIdx] = tmp;
                        dstIdx++;                        
                    }
                }

                return new string(scrArr);
            }

            public static char[] ReverseWords(char[] words)
            {
                var strIdx = 0;
                var endIdx = 0;
                while(true)
                {
                    endIdx = System.Array.IndexOf<char>(words, ' ', strIdx);
                    if (endIdx != -1)
                    {
                        Array.ReverseWord(words, strIdx, endIdx);
                        strIdx = endIdx + 1;
                    }
                    else //last section
                    {
                        Array.ReverseWord(words, strIdx, words.Length);
                        break;
                    }                    
                }

                Array.ReverseWord(words, 0, words.Length);

                return words;

            }

            public static char[] ReverseWord(char[] word,int start, int end)
            {
                end -= 1;

                var half = ((end - start) / 2) + start;
                char tmp;
                while (start <= half)
                {
                    tmp = word[start];
                    word[start] = word[end];
                    word[end] = tmp;

                    start++;
                    end--;
                }
                
                return word;
            }
        }
    }
}
