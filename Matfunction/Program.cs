using System;
namespace Matfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(number));
            Console.WriteLine(Math.Sqrt(number));
            Console.WriteLine(Math.Round(Math.PI,3));
        }
    }
}