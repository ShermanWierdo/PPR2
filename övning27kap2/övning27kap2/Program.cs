using System;
class TriangelTest

{
    static void Main()
    {
        Triangel tri = new Triangel();

        tri.sida_a = 4;
        tri.sida_b = 6;
        tri.sida_c = 5;
        tri.höjd_b = 3;
    
        Console.WriteLine("\n\tMed den första referensen:\n" + "\tArea = " + tri.area() + '\n' + "\tOmkrets = " + tri.omkrets() + '\n');
        Triangel t = tri;

        Console.WriteLine("\n\tMed den andra referensen:\n" + "\tArea = " + t.area() + '\n' + "\tOmkrets = " + t.omkrets() + '\n');
        tri = null;

        Console.WriteLine("Användning av null-referens ger " + "exekveringsfel:\n");

        Console.WriteLine(tri.sida_a);
    }
}
//unfinished