//Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 

using System;

class Program
{
    static bool EstePalindrom(int n)
    {
        int invers = 0;
        int temp = n;

        while (temp > 0)
        {
            int cifra = temp % 10;
            invers = (invers * 10) + cifra;
            temp /= 10;
        }

        return n == invers;
    }

    static void Main()
    {
        Console.WriteLine("Introdu un numar: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        if (EstePalindrom(numar))
        {
            Console.WriteLine($"{numar} este un numar palindrom.");
        }
        else
        {
            Console.WriteLine($"{numar} nu este un numar palindrom.");
        }
    }
}
