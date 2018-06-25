using System;
class QuestionOne
{
   static void Main(string[] args)
   {
     Console.WriteLine("Enter first num");
     int a=int.Parse(Console.ReadLine());
     Console.WriteLine("Enter Second num");
     int b=int.Parse(Console.ReadLine());
     if(a>b)
      {

         int temp=b;
         b=a;
         a=temp;
         
        Console.WriteLine("The A is::"+a+"B is::"+b);
      }
    

    }
 


}