using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfStrings
{
    class Program
    {
        static string SumInWords(int sum)
        {
            string[] ar1 = { "", "один рубль", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять" };
            string[] ar2 = { "", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] ar3 = { "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяноста" };
            string[] ar4 = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] ar5 = { "", "тысяча", "две тысячи", "тысячи", "тысяч" };

            int x = sum / 1000;
            int y = sum / 100 % 10;
            int z = sum / 10 % 10;
            int w = sum % 10;
            string t = "";
            string d = "";

            if (x == 0)
            {
                y = sum / 100;
                z = sum / 10 % 10;
                w = sum % 10;

                if (z == 1)
                {
                    d = ar2[w];
                }
                else if (z > 1)
                {
                    d = ar3[--z] + " " + ar1[w];
                }

                return ar4[y] + " " + d;
            }

            if (x == 1)
            {
                t = ar5[1];
            }
            else if ((x >= 2) && (x < 5))
            {
                if (x == 2)
                {
                    t = ar5[x];
                }
                else
                {
                    t = ar1[x] + " " + ar5[3];
                }

            }
            else if (x < 11)
            {
                t = ar1[x] + " " + ar5[4];
            }
            else if (x < 19)
            {
                t = ar2[x % 10] + " " + ar5[4];
            }
            else
            {
                if (x % 10 == 1)
                {
                    t = ar3[x % 10] + " одна " + ar1[x % 10];
                }
                else
                {
                    int xi = x / 10;
                    if (x % 10 >= 5)
                    {
                        t = ar3[--xi] + " " + ar1[x % 10] + " " + ar5[4];
                    }
                    else
                    {
                        t = ar3[--xi] + " " + ar1[x % 10] + " " + ar5[3];
                    }
                }

            }
            if (z == 0)
            {
                d = "" + ar1[w];
            }
            else if (z == 1)
            {
                d = ar2[w];
            }
            else
            {
                d = ar3[--z] + " " + ar1[w];
            }

            string r = "";

            if (((w == 0) || (w > 4)) || (z == 1))
            {
                r = " рублей";
            }
            else
            {
                r = " рубля";
            }

            return t + " " + ar4[y] + " " + d + r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("12 - " + SumInWords(12) + "\n");
            Console.WriteLine("123 - " + SumInWords(123) + "\n");
            Console.WriteLine("1234 - " + SumInWords(1234) + "\n");
            Console.WriteLine("2345 - " + SumInWords(2345) + "\n");
            Console.WriteLine("3456 - " + SumInWords(3456) + "\n");
            Console.WriteLine("12345 - " + SumInWords(12345) + "\n");
            Console.WriteLine("23456 - " + SumInWords(23456) + "\n");
            Console.WriteLine("34567 - " + SumInWords(34567) + "\n");
            Console.WriteLine("45678 - " + SumInWords(45678) + "\n");
            Console.WriteLine("56789 - " + SumInWords(56789) + "\n");
            Console.WriteLine("99999 - " + SumInWords(99999) + "\n");
        }
    }
}
