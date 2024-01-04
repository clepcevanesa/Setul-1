//Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul pentru descompunerea în factori primi: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Descompunerea in factori primi a lui " + n + " este: ");
        DescompunereInFactoriPrimi(n);
    }

    static void DescompunereInFactoriPrimi(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.Write(i);
                n /= i;

                if (n != 1)
                {
                    Console.Write(" x ");
                }
            }
        }
    }
}
