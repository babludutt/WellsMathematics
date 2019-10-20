using System;
namespace WellsMathematics
{
    public class PowerProgram
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter x, y to calculate Power(x, y)");
                try
                {
                    double.TryParse(Console.ReadLine(), out double x);

                    double.TryParse(Console.ReadLine(), out double y);

                    double result = Power(x, y);
                    Console.WriteLine(result);

                    //Console.WriteLine("Output using Math.Power = " + Math.Pow(x, y));
                }
                catch (OverflowException)
                {
                    Console.WriteLine("OverflowException occured, please enter smaller values");
                }
                Console.Read();
            }

        }

        public static double Power(double x, double n)
        {
            double result = 1;
            while (n > 0)
            {
                if (n % 2 > 0)
                {
                    result = result * x;
                    n = n - 1;
                }

                x = x * x;
                n = n / 2;
            }

            return result;
        }
    }
}