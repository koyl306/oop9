using System;

namespace _9pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sumOfSquares = (a, b) => a * a + b * b;

            int x = 3;
            int y = 4;
    
            int result = sumOfSquares(x, y);
            Console.WriteLine(result);
        }
    }
}