using System;
class Cirkel
{
    public double radie;

    public double area()
    {
        return Math.PI * radie * radie;
    }
    public double omkrets()
    {
        return 2 * Math.PI * radie;
    }
}
