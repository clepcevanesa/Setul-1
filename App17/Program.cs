//Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 

using System;

class EuclideanAlgorithm
{
    static int ComputeGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    
    static int ComputeLCM(int a, int b)
    {
        int gcd = ComputeGCD(a, b);
        int lcm = (a * b) / gcd;
        return lcm;
    }

    static void Main()
    {
        Console.WriteLine("Introduceti primul numar:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = ComputeGCD(num1, num2);
        int lcm = ComputeLCM(num1, num2);

        Console.WriteLine($"Cel mai mare divizor comun al celor două numere este: {gcd}");
        Console.WriteLine($"Cel mai mic multiplu comun al celor două numere este: {lcm}");

        Console.ReadLine();
    }
}
