using System;

namespace SumofDigits
{
    class Program
    {
        public static int Sum(int n)
        {
            if (n / 10 == 0)
                return n;
            return Sum(n / 10) + n % 10;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number");

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of digits of number is " + Sum(n));
        }
    }
}
