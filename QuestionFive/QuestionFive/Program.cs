using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter input");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;

                case 2:
                    Console.WriteLine("TWO");

                    break;

                case 3:
                    Console.WriteLine("Three");

                    break;

                case 4:
                    Console.WriteLine("Four");

                    break;

                case 5:
                    Console.WriteLine("Five");

                    break;

                case 6:
                    Console.WriteLine("Six");

                    break;

                case 7:
                    Console.WriteLine("SEVEN");

                    break;

                case 8:
                    Console.WriteLine("EIGHT");

                    break;

                case 9:
                    Console.WriteLine("NINE");

                    break;
                default:
                    Console.WriteLine("Enter correct Choice");
                    break;

                   
            }
            Console.ReadKey();
        }
    }
}
