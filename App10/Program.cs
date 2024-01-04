//Test de primalitate: determinati daca un numar n este prim.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti un numar: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        if (EstePrim(numar))
        {
            Console.WriteLine($"{numar} este un numar prim.");
        }
        else
        {
            Console.WriteLine($"{numar} nu este un numar prim.");
        }

        Console.ReadLine();
    }

    static bool EstePrim(int numar)
    {
        if (numar <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numar); i++)
        {
            if (numar % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
