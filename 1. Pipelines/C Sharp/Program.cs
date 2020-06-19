using System;
using System.Linq;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Enumerable
                                .Range(1, 10)
                                .Where(number => number % 2 == 0)
                                .Select(number => number * number)
                                .Aggregate((a,b) => a + b);
            
            Console.WriteLine(sum);
        }
    }
}
