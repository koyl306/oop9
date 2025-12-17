using System;

namespace _9pr
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());

            Func<double, double> positiveLambda = a => a * a + 4;
            Func<double, double> nonPositiveLambda = a => 0;
    
            double result;
            if (x > 0)
            {
                result = positiveLambda(x);
            }
            else
            {
                result = nonPositiveLambda(x);
            }
    
            Console.WriteLine(result);
        }
    }
}