// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3, num4, num5;

        Console.WriteLine("Introduceti primul numar:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti al treilea numar:");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti al patrulea numar:");
        num4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti al cincilea numar:");
        num5 = Convert.ToInt32(Console.ReadLine());

        int temp;

        if (num1 > num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        if (num2 > num3)
        {
            temp = num2;
            num2 = num3;
            num3 = temp;
        }
        if (num3 > num4)
        {
            temp = num3;
            num3 = num4;
            num4 = temp;
        }
        if (num4 > num5)
        {
            temp = num4;
            num4 = num5;
            num5 = temp;
        }
        if (num1 > num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        if (num2 > num3)
        {
            temp = num2;
            num2 = num3;
            num3 = temp;
        }
        if (num3 > num4)
        {
            temp = num3;
            num3 = num4;
            num4 = temp;
        }
        if (num1 > num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        if (num2 > num3)
        {
            temp = num2;
            num2 = num3;
            num3 = temp;
        }
        if (num1 > num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine("Numerele ordonate crescator sunt: {0} {1} {2} {3} {4}", num1, num2, num3, num4, num5);
    }
}
