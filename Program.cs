using System;

namespace RandomFibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long total = 0;
            long iterations = 1000000;
            for (var i = 0; i < iterations; i++)
            {
                var steps = 20;
                long result = RandomFibonacci.Calculate(steps);
                // Console.WriteLine(result);
                total += result;
            }
            Console.WriteLine(total / (double)iterations);
        }
    }
}
