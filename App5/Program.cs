//Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 

using System;

class MainClass
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul:");
        int numar = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti valoarea lui k:");
        int k = int.Parse(Console.ReadLine());

        int cifra = ExtrageCifra(numar, k);
        Console.WriteLine($"Cifra a {k}-a de la sfarsitul numarului este: {cifra}");
    }

    static int ExtrageCifra(int numar, int k)
    {
        for (int i = 1; i < k; i++)
        {
            numar /= 10;
        }
        return numar % 10;
    }
}
