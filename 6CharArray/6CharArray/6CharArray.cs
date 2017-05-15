using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharArray
{
    class Program
    {
        static void PrintCharAr(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine("\n");
        }

        static String CharArrayToString(char[] ar)
        {
            return new string(ar);
        }

        static int IndexOfStr(char[] s1, char[] s2)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            bool check = false;
            for (i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[0])
                {
                    k = i;
                    for (j = 1; j < s2.Length; j++)
                    {
                        if (s1[++i] == s2[j]) check = true;
                    }
                    if (check) return k;
                }
            }
            return -1;
        }

        static int TestIndexSym(char[] s1, char[] s2)
        {
            bool check = false;
            int k = 0;

            if (s2.Length == 1)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s2[0])
                    {
                        check = true;
                        if (check) return i;
                    }
                }
                return -1;
            }
            else
            {
                int i = 0;
                int j = 0;

                for (i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s2[0])
                    {
                        k = i;
                        for (j = 1; j < s2.Length; j++)
                        {
                            if (s1[++i] == s2[j]) check = true;
                        }
                        if (check) return k;
                    }
                }
                return -1;
            }
        }

        static void Main(string[] args)
        {
            //char[] str1 = "Hello, World!";
            string str2 = "Hello, world!";

            PrintCharAr(str2.ToCharArray());

            Console.WriteLine(CharArrayToString(str2.ToCharArray()));

            Console.WriteLine("\n'world' входит в строку начиная с " + IndexOfStr(str2.ToCharArray(), "world".ToCharArray()) + "-го символа\n");

            Console.WriteLine("\n'o' входит в строку начиная с " + TestIndexSym(str2.ToCharArray(), "o".ToCharArray()) + "-го символа\n");
        }
    }
}
