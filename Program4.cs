using System;

namespace _9pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> sumEvenNumbers = n =>
            {
                int sum = 0;
                for (int i = 2; i <= n; i += 2)
                {
                    sum += i;
                }
                return sum;
            };
    
            int n = int.Parse(Console.ReadLine());
            int result = sumEvenNumbers(n);
    
            Console.WriteLine(result);
        }
    }
}