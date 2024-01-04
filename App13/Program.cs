//Determianti cati ani bisecti sunt intre anii y1 si y2.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti primul an: ");
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea an: ");
        int y2 = int.Parse(Console.ReadLine());

        int count = CountLeapYears(y1, y2);

        Console.WriteLine($"intre anii {y1} și {y2} sunt {count} ani bisecti.");
    }

    static int CountLeapYears(int year1, int year2)
    {
        int count = 0;
        for (int year = year1; year <= year2; year++)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                count++;
            }
        }
        return count;
    }
}
