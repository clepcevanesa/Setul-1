//Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

using System;
using System.Linq;

class Program
{
    static bool AreOnlyTwoRepeatingDigits(int number)
    {
        // Convertim numărul în șir de caractere pentru a putea lucra cu cifrele individuale
        string numberString = number.ToString();

        // Folosim Linq pentru a număra câte cifre unice avem în număr
        int distinctDigitCount = numberString.Distinct().Count();

        // Dacă avem exact 2 cifre unice, atunci numărul este format doar din 2 cifre care se pot repeta
        return distinctDigitCount == 2;
    }

    static void Main()
    {
        Console.WriteLine("Introduceti un numar pentru a verifica daca este format doar din 2 cifre care se pot repeta:");
        int numar;

        // Încercăm să citim și să convertim numărul introdus de la utilizator
        bool isValidNumber = int.TryParse(Console.ReadLine(), out numar);

        if (isValidNumber)
        {
            if (AreOnlyTwoRepeatingDigits(numar))
            {
                Console.WriteLine($"{numar} este format doar din 2 cifre care se pot repeta.");
            }
            else
            {
                Console.WriteLine($"{numar} nu este format doar din 2 cifre care se pot repeta.");
            }
        }
        else
        {
            Console.WriteLine("Introduceti un numar valid.");
        }
    }
}
