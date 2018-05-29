using System;
class CirkelTest
{
    static void Main()
    {
        Cirkel minCirkel;
        minCirkel = new Cirkel();

        Console.Write("\n\tAnge radien till en cirkel:\t");
        minCirkel.radie = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine ("\n\tEn cirkel med radien " + minCirkel.radie + "\n\thar arean " + minCirkel.area() + "\n\toch omkretsen " + minCirkel.omkrets() + '\n');
        minCirkel.radie = Convert.ToDouble(Console.ReadLine());
    }
}
