using System;
class Procedural
{
    static void Main(string[] args)
    {
        double radie;

        Console.Write("\n\tAnge radien till en cirkel: \t");
        radie = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n\tEn cirkel med radien " + radie + "\n\thar arean " + area(radie) + "\n\toch omkretsen " + omkrets(radie) + '\n');
        radie = Convert.ToDouble(Console.ReadLine());
    }
    static double area(double r)
    {
        return Math.PI * r * r;
    }
    static double omkrets(double r)
    {
        return 2 * Math.PI * r;
    }
}