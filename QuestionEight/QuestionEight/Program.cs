using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for int 2 for double 3 for character::");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {

                case 1:
                    Console.WriteLine("enter integer number::");
                    int integer = int.Parse(Console.ReadLine());
                    integer++;
                    Console.WriteLine("Value is ::"+integer);
                    break;
                case 2:
                    Console.WriteLine("enter integer number::");
                    double dbl = double.Parse(Console.ReadLine());
                    dbl++;
                    Console.WriteLine("value double is::"+dbl);
                    break;

                 
                case 3:
                    Console.WriteLine("Enter string:: ");
                    string str = Console.ReadLine();
                    str = str+"*";
                    Console.WriteLine(""+str);

                    break;





            }

            Console.ReadKey();
        }
    }
}
