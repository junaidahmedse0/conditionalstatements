using System;
class QuestionThree
{
  static void Main(string[] args)
  {

    int a,b,c;
    Console.WriteLine("Enter a:: ");
      a=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter b:: ");
      b=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter c:: ");
      c=int.Parse(Console.ReadLine());
     if(a>b&& b>c)
      {
        Console.WriteLine("A is greater"+a); 
      }
     else if(b>a && a>c)
      {
        Console.WriteLine("B is greater"+b); 
      }
      else
      {
        Console.WriteLine("C is greater"+c); 
      }


  }




}