using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Example 1";
            string str2 = new string('E', 5);
            char[] chararray = { 'E', 'x', 'a', 'm', 'p', 'l', 'e', '№', '2' };
            string str3 = new string(chararray);

            Console.WriteLine(str1 + "\n" + str2 + "\n" + str3 + "\n");

            Console.WriteLine("str1 = " + (str1 = str2) + "\n");

            Console.WriteLine("str1 = str2 ? - " + (str1 == str2));
            Console.WriteLine("str1 != str3 ? - " + (str1 != str3));

            Console.WriteLine("\nstr1 + str2 = " + str1 + str3);

            Console.WriteLine("\nstr3[3] = " + str3[3] + "\n\n");


            string str4 = "C#(student)";
            string comment = "";

            Console.WriteLine("str4 = " + str4 + "\n");

            for (int i = 0; i < str4.Length; i++)
            {
                if (str4[i] == '(')
                {
                    for (int j = i; j < str4.Length; j++)
                    {
                        if (str4[j] == ')')
                        {
                            int len = j - i - 1;
                            ++i;
                            comment = str4.Substring(i, len);
                        }
                    }
                }
            }

            Console.WriteLine("Comment of str4 - " + comment + "\n");

            string reserve = "";
            string notstudent = "";

            for (int i = 0; i < str4.Length; i++)
            {
                if (str4[i] == 's')
                {
                    reserve = str4.Substring(i, 7);
                    if (reserve == "student")
                    {
                        int j = i + 7;
                        int len = str4.Length - j;
                        notstudent = str4.Substring(0, i) + str4.Substring(j, len);
                    }
                }
            }

            Console.WriteLine("Str notstudent - " + notstudent + "\n");
        }
    }
}
