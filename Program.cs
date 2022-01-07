using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class SumExample
    {
       public static void Main(string[] args)
        {
           int n,aum=0,m;
           Console.Write("Enter a number: ");
           n=int.parse(Console.ReadLine());
           whlie(n>0)
           {
               m=n%10;
               sum=sum+m;
               n=n/10;
           }
           Console.Write("Sum is= + sum);
           Console.Read();
    }
}
