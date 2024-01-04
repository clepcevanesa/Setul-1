//Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).
//O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
//O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
//O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 

using System;

class FractieDecimala
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti numaratorul (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numitorul (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Fracția {m}/{n} în format zecimal este: {ConversieFractieDecimala(m, n)}");
    }

    static string ConversieFractieDecimala(int m, int n)
    {
        if (n == 0)
        {
            return "Eroare: Denominatorul nu poate fi zero!";
        }

        int parteIntreaga = m / n;
        int rest = m % n;

        if (rest == 0)
        {
            return parteIntreaga.ToString();
        }

        var parteFractionara = new System.Text.StringBuilder();
        var resturi = new System.Collections.Generic.Dictionary<int, int>();

        while (rest != 0 && !resturi.ContainsKey(rest))
        {
            resturi.Add(rest, parteFractionara.Length);
            rest *= 10;
            parteFractionara.Append(rest / n);
            rest %= n;
        }

        if (rest != 0)
        {
            parteFractionara.Insert(resturi[rest], "(");
            parteFractionara.Append(")");
        }

        return $"{parteIntreaga}.{parteFractionara.ToString()}";
    }
}
