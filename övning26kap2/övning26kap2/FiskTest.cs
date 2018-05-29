using System;
namespace FiskTest
{
    class FiskTest
    {
        static void Main()
        {
            Fisk f1 = new Fisk();
            Fisk f2 = new Fisk();

            Console.Write("\n\tMata in sorten till en fisk1:\t");
            f1.sort = Console.ReadLine();
            if (f1.sort.Length < 6) f2.sort += '\t';
            Console.Write("\n\tMata in vikten till en fisk1 (g):\t");
            f1.vikt = (float) Convert.ToDecimal (Console.ReadLine());
            Console.Write("\n\tMata in längden till en fisk1:\t");
            f1.längd = (float) Convert.ToDecimal (Console.ReadLine());

            Console.Write("\n\tMata in sorten till en fisk2:\t");
            f2.sort = Console.ReadLine();
            if (f2.sort.Length < 6) f2.sort += '\t';
            Console.Write("\n\tMata in vikten till en fisk2 (g):\t");
            f2.vikt = (float) Convert.ToDecimal (Console.ReadLine());
            Console.Write("\n\tMata in längden till en fisk2:\t");
            f2.längd = (float) Convert.ToDecimal (Console.ReadLine());

            Console.WriteLine("\nFisksort\tVikt i g\tLängd i cm" + "\tPris\tFrakt\n" + "------------------------------------------------------\n" + f1.sort + "     " + "\t" + f1.vikt + "\t\t" + f1.längd + "\t\t" + f1.pris() + "\t" + f1.frakt() + "\n" + f2.sort + "\t" + f2.vikt + "\t\t" + f2.längd + "\t\t" + f2.pris() + "\t" + f2.frakt() + "\n\n");

            string stop;
            Console.Write(stop = (Console.ReadLine()));
        }
    }
}