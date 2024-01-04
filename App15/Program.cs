//Se dau 3 numere. Sa se afiseze in ordine crescatoare. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti cele trei numere:");
        Console.Write("Numarul 1: ");
        int numar1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Numarul 2: ");
        int numar2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Numarul 3: ");
        int numar3 = Convert.ToInt32(Console.ReadLine());

        int[] numere = { numar1, numar2, numar3 };
        SortareCrescatoare(numere);

        Console.WriteLine("Numerele sortate in ordine crescatoare sunt:");
        foreach (int numar in numere)
        {
            Console.Write(numar + " ");
        }
    }

    static void SortareCrescatoare(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
