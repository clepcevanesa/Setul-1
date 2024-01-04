//(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti valoarea pentru a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti valoarea pentru b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Inainte de inversare: a = {a}, b = {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"Dupa inversare: a = {a}, b = {b}");
    }
}
