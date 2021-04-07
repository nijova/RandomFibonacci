using System;

namespace RandomFibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var steps = 4;
            long result = RandomFibonacci.Calculate(steps);
            Console.WriteLine(result);
        }
    }
}
