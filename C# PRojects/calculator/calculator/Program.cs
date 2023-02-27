using System;

namespace calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("First Number: ");
            int first = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int second = Int32.Parse(Console.ReadLine());
            int result = first + second;
            Console.WriteLine(first + " + " + second + " = " + result);
            result = first - second;
            Console.WriteLine(first + " - " + second + " = " + result);
            result = first / second;
            Console.WriteLine(first + " / " + second + " = " + result);
            result = first * second;
            Console.WriteLine(first + " * " + second + " = " + result);
        }
    }
}
