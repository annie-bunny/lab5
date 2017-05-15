using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
public StringBuilder Append (<объект>)
    к строке, вызвавшей метод, присоединяется строка, полученная из объекта, который передан методу в качестве параметра;
public StringBuilder Insert (int location,<объект>)
    вставляет строку, полученную из объекта, в позицию, указанную параметром location. 
public StringBuilder Remove (int start, int len)
    удаляет подстроку длины len, начинающуюся с позиции start;
public StringBuilder Replace (string str1,string str2)
    все вхождения подстроки str1 заменяются на строку str2;
public StringBuilder AppendFormat (<строка форматов>, <объекты>)
    Метод является комбинацией метода Format класса String и метода Append.*/

namespace ExampleStringBuilder
{
    class Program
    {
        static void TestStringBuilder()
        {
            StringBuilder str1 = new StringBuilder("String - example of StringBuilder");

            Console.WriteLine("STR1 - " + str1 + "\n");

            str1.Insert(7, "testing");
            Console.WriteLine("STR1 (INSERT) - " + str1 + "\n");

            str1.Remove(10, 17);
            Console.WriteLine("STR1 (REMOVE) - " + str1 + "\n");

            str1.Replace("String", "StringBuilder");
            Console.WriteLine("STR1 (REPLACE) - " + str1 + "\n");
        }

        static void Main(string[] args)
        {
            TestStringBuilder();

            StringBuilder strbuild = new StringBuilder("");
            StringBuilder txtbuild = new StringBuilder("");

            strbuild.Insert(0, "Main, STRING, uibiub iuiub");
            strbuild.Append(", QWERTYUIOP");

            Console.WriteLine(strbuild + "\n");

            txtbuild.Append(strbuild);

            int k = 0;
            foreach (string i in txtbuild.ToString().Split(','))
            {
                txtbuild.AppendFormat("{0}:{1}", k++, ',');
                Console.WriteLine("№ " + k + " - " + i);
            }

            Console.WriteLine("\nCapacity txtbuild = " + txtbuild.Capacity);
            Console.WriteLine("Maxcapacity txtbuild = " + txtbuild.Capacity);
            Console.WriteLine("\nCapacity strbuild = " + strbuild.Capacity);
            Console.WriteLine("Maxcapacity strbuild = " + strbuild.Capacity);

            txtbuild.EnsureCapacity(50);
            strbuild.EnsureCapacity(50);

            Console.WriteLine("\n\nEnsureCapacity(50)");
            Console.WriteLine("\nCapacity txtbuild = " + txtbuild.Capacity);
            Console.WriteLine("Maxcapacity txtbuild = " + txtbuild.Capacity);
            Console.WriteLine("\nCapacity strbuild = " + strbuild.Capacity);
            Console.WriteLine("Maxcapacity strbuild = " + strbuild.Capacity);
        }
    }
}
