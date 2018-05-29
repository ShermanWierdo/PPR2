using System;
class Procedural
{
    static void Main(string[] args)
    {
        double radie, area, omkrets;

        Console.Write("\n\tAnge radien till en cirkel: \t");
        radie = Convert.ToDouble(Console.ReadLine());

        area = Math.PI * radie * radie;
        omkrets = 2 * Math.PI * radie;

        Console.WriteLine("\n\tEn cirkel med radien " + radie + "\n\thar arean " + area + "\n\toch omkretsen " + omkrets + '\n');
        radie = Convert.ToDouble(Console.ReadLine());
    }
}