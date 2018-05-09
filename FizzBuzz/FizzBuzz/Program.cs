using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersList = Enumerable.Range(1, 100).ToList();
            
                foreach (int element in numbersList)
                {
                if ((element % 3 == 0) && (element % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (element % 3 == 0)
                {
                     Console.WriteLine("Fizz");
                }
                 else if (element % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(element);
                }
                     
                             
               
                }
        }
    }
}
