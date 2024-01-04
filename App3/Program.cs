//Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti n:");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti k:");
        int k=Convert.ToInt32(Console.ReadLine());

        if (n%k==0)
        {
            Console.WriteLine($"{n} se divide cu {k}");
        }
        else
        {
            Console.WriteLine($"{n} nu se divide cu {k}");
        }
     }    
}