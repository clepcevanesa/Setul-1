//Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 

using System;
    class Program
    {
        static void Main()
        {
            float a, b, x;
            Console.Write("Introduceti a= ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti b= ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Ecuatie nedeterminata");
                else
                    Console.WriteLine("Ecuatie imposibila");
            else
            {
                x = -b / a;
                Console.WriteLine("Solutia este x={0}", x);
            }
            Console.ReadKey();
        }
    }