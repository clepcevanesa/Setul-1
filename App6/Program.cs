//Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti lungimile laturilor:");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (VerificaTriunghi(a, b, c))
        {
            Console.WriteLine("Aceste lungimi pot forma un triunghi.");
        }
        else
        {
            Console.WriteLine("Aceste lungimi NU pot forma un triunghi.");
        }

        Console.ReadLine();
    }

    static bool VerificaTriunghi(double a, double b, double c)
    {
        // Un triunghi poate fi format doar dacă suma oricăror două laturi este mai mare decât a treia latură.
        return a + b > c && a + c > b && b + c > a;
    }
}
