using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a:: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:: ");
            c= int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, b, c);


                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }



                }
                else
                    Console.WriteLine("{0} {1} {2}", c, a, b);



            }// 1st if ended

            else if (b > c)
            {
                if (a > c)
                {

                    Console.WriteLine("{0} {1} {2}", b, a, c);


                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);

                }



            }
            else
            {

                Console.WriteLine("{0} {1} {2}", c,b,a);
            }


            Console.ReadKey();
        }





    }
}
