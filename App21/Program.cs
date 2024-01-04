//Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

using System;

class Program
{
    static void Main()
    {
        int min = 1;
        int max = 1024;
        int guess;
        bool found = false;

        Console.WriteLine("Alege un numar intre 1 si 1024.");

        while (!found)
        {
            guess = (min + max) / 2;

            Console.WriteLine($"Numarul este mai mare sau egal decat {guess}? (da/nu)");
            string input = Console.ReadLine().ToLower();

            if (input == "da")
            {
                min = guess + 1;
            }
            else if (input == "nu")
            {
                max = guess - 1;
            }
            else
            {
                Console.WriteLine("Te rog sa raspunzi cu 'da' sau 'nu'.");
                continue;
            }

            if (min > max)
            {
                Console.WriteLine("Nu ai ales un raspuns corect.");
                break;
            }
            else if (min == max)
            {
                Console.WriteLine($"Numarul este {min}!");
                found = true;
            }
        }

        Console.ReadKey();
    }
}
