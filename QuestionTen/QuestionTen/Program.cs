using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("The result is::" + (number * 10));
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine("The result is::" + (number * 100));
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("The result is::" + (number * 1000));
                    break;


            }
            Console.ReadKey();


        }
    }
}
