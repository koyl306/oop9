using System;

namespace _9pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isPositive = x => x > 0;

            int number = int.Parse(Console.ReadLine());
    
            bool result = isPositive(number);
            Console.WriteLine(result);
        }
    }
}