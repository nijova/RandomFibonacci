using System;

namespace RandomFibonacci
{
    public static class RandomFibonacci
    {
        private static Random R = new Random();

        public static long Calculate(int steps, int currentStep = 0, long f_minus_1 = 1, long f_minus_2 = 1)
        {
            var sign = R.Next(-1, 1) >= 0 ? 1 : -1;
            long f_temp = f_minus_1 + sign * f_minus_2;
            if (currentStep++ < steps)
            {
                f_minus_2 = f_minus_1;
                f_minus_1 = f_temp;
                return Calculate(steps, currentStep, f_minus_1, f_minus_2);
            }
            return f_temp;
        }
    }
}
