//(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 

using System;

class Program
{
    static void Main()
    {
  
        Console.WriteLine("Introduceti valoarea pentru a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti valoarea pentru b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Valorile initiale: a = {a}, b = {b}");

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"Valorile inverse: a = {a}, b = {b}");

        Console.ReadLine();
    }
}
