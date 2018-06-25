using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;

            Console.WriteLine("Enter A::");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B::");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter C::");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter D::");
            d= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter E::");
            e = int.Parse(Console.ReadLine());
            if (a < b)
                a = b;
            if (a < c)
                a = c;
            if (a < d)
                a = d;
            if (a < e)
                a = e;
            Console.WriteLine("The output is::" + a);

            Console.ReadKey();
        }
    }
}
