using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 4, 3, 6, 9, 12, 15 };
        int n = arr.Length;
        int maxDiff = arr[1] - arr[0];
        for (int i = 0; i < n - 1; i++)
        {
            int diff = arr[i + 1] - arr[i];
            if (diff > maxDiff)
            {
                maxDiff = diff;
            }
        }
        Console.WriteLine("A szomszédos elemek közötti maximális különbség: " + maxDiff);
    }
}