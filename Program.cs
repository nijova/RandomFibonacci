using System;

namespace RandomFibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (var i = 0; i < 1000; i++)
            {
                var steps = 100;
                long result = RandomFibonacci.Calculate(steps);
                Console.WriteLine(result);
            }
        }
    }
}
