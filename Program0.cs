﻿public class Program
{
    public static void Main(string[] args)
    {
        int n = 4, a = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                a++;
            }
        }
        if (a == 2)
        {
            Console.WriteLine("{0} is a Prime Number", n);
        }
        else
        {
            Console.WriteLine("Not a Prime Number");
        }
        Console.ReadLine();
    }
}