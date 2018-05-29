using System;
class kubtest

namespace övning34kap3

{
    static void Main()
    {
    Kub minKub;

    minKub = new Kub();


    Console.Write("\n\tAnge sidan till en kub:\t");
    minKub.sida = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\n\tEn kub med sidan\t" + minKub.sida + "\n\thar volymen\t\t" + minKub.Volym() + "\n\toch ytan\t\t" + minKub.Yta() + '\namespace');
    }
}

