using System;

namespace MyLib
{
    public sealed partial class Pudelko
    {
        public static Pudelko operator +(Pudelko p1, Pudelko p2)
        {
            double d1 = p1.A + p2.A;
            double d2 = p1.B > p2.B ? p1.B : p2.B;
            double d3 = p1.C > p2.C ? p1.C : p2.C;

            return new Pudelko(d1, d2, d3);
        }
    }
}
