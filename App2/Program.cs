//Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti coeficientii pentru ecuatia de gradul 2 ");

        Console.WriteLine("a=");
        double a= double.Parse(Console.ReadLine());

        Console.WriteLine("b=");
        double b= double.Parse(Console.ReadLine());

        Console.WriteLine("c=");
        double c= double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("Ecuatia nu este de gradul 2.");
        }
        else if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Doua solutii reale distincte: x1={x1}, x2={x2}");
        }
        else if (delta==0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"O singura solutie reala: x={x}");
        }
        else
        {
            double realPart=-b/(2 * a);
            double imaginaryPart=Math.Sqrt(-delta)/(2 * a);
            Console.WriteLine($"Doua solutii complexe conjugate: x1={realPart}+{imaginaryPart}i, x2={realPart}-{imaginaryPart}i");

        }
        Console.ReadLine();
    }
}


