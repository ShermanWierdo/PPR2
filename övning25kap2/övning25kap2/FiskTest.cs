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

            Console.WriteLine("\nFisksort\tVikt i g\tLängd i cm" + "\tPris\tFrakt\n" + "------------------------------------------------------\n" + f1.sort + "\t" + f1.vikt + "\t\t" + f1.längd + "\t\t" + f1.pris() + "\t" + f1.frakt() + "\n" + f2.sort + "\t" + f2.vikt + "\t\t" + f2.längd + "\t\t" + f2.pris() + "\t" + f2.frakt() + "\n\n");

            string stop;
            Console.Write(stop = (Console.ReadLine()));
        }
    }
}