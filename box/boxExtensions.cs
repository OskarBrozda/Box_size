using System;

namespace MyLib
{
    public static class PudelkoExtensions
    {
        public static Pudelko Kompresuj(this Pudelko p)
        {
            double x = Math.Pow(p.Objetosc, 1.0 / 3);
            return new Pudelko(x, x, x);
        }
    }
}

