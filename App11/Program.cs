//Afisati in ordine inversa cifrele unui numar n. 

using System;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Introduceti un numar: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cifrele numarului in ordine inversa sunt: ");
        while (numar > 0)
        {
            int cifra = numar % 10;
            Console.Write(cifra);
            numar = numar / 10;
        }

        Console.WriteLine();
    }
}
