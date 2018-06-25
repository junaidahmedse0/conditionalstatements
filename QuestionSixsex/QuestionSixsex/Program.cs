using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSixsex
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
            c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("This is not a Quardratic equation");


            }
            else
            {
                double disc = (b * b )- (4 * a * c);
                if (disc > 0)
                {

                    double x1 = (-b + Math.Sqrt(disc)) / 2 * a;

                    double x2 = (-b - Math.Sqrt(disc)) / 2 * a;

                    Console.WriteLine("Equations roots are{0} {1}", x1, x2);

                }
                else if (disc == 0)
                {
                    Console.WriteLine("The equation have only one root" + (-b / 2 * a));


                }
                else if (disc < 0)
                {

                    Console.WriteLine("the equation have no roots");


                }




            }
            Console.ReadKey();
        }

    }
}
