using System;

namespace IntegersAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;

            Console.WriteLine("Enter First Number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = int.Parse(Console.ReadLine());

            sum = a + b;
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
