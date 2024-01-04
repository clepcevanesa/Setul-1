//Detreminati daca un an y este an bisect.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti anul:");
        int an=Convert.ToInt32(Console.ReadLine());

        if ((an%4==0 && an%100!=0) || (an%400==0))
        {
            Console.WriteLine($"{an} este un an bisect");
        }
        else
        {
            Console.WriteLine($"{an} nu este un an bisect");
        }
    }
}
