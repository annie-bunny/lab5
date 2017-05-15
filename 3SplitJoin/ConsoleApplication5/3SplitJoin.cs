using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitJoin
{
    class Program
    {
        static void JoinSplitWords(string str)
        {
            string[] SimpleSentences,   //состоит из простых предложений, сост. осн. строку
                     Words;             //состоит из слов, сост. осн. строку

            SimpleSentences = str.Split(',');

            Console.WriteLine("\nОсновное предложение - " + str + "\n");

            int k = 1;
            for (int i = 0; i < SimpleSentences.Length; i++)
            {
                Console.WriteLine("Простое предложение №" + (k++) + " - " + SimpleSentences[i]);
            }
            Console.WriteLine();

            Words = str.Split(' ');

            k = 0;
            for (int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine("Слово №" + (k++) + " - " + Words[i]);
            }



            Console.WriteLine("\nСобранная строка  - " + String.Join(" ", Words) + "\n");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();

            JoinSplitWords(s);
        }
    }
}
