//Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 

using System;

class Program
{
    static void Main()
    {

        Console.Write("Introduceti n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Numere divizibile cu {n} în intervalul [{a}, {b}]: {count}");
    }
}
