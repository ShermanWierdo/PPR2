using System;
namespace FiskTest
{
    class FiskTest
    {
        static void Main()
        {
            Fisk f1 = new Fisk();
            f1.sort = "Laxforell";
            f1.vikt = 719;
            f1.längd = 38.5;

            Fisk f2 = new Fisk();
            f2.sort = "Torsk\t";
            f2.vikt = 423;
            f2.längd = 28.7;

            Console.WriteLine("\n\tFisksort\tVikt i g\tLängd i cm" + "\n\t-------------------------------\n\t" + f1.sort + "\t " + f1.vikt + "\t\t " + f1.längd + "\n\t" + f2.sort + "\t " + f2.vikt + "\t\t " + f2.längd + "\n\t");

            string stop;
            Console.Write(stop = (Console.ReadLine()));
        }
    }
}
