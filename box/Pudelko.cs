using System;
using System.Linq;
using P = MyLib.Pudelko;

namespace MyLib
{
    public class Pudelko
    {
        private double a { get; set; }
        public double A
        {
            get => Math.Round(a, 3);
            set
            {
                if (value > 10 || value < 0) throw new ArgumentOutOfRangeException();
                a = value;
            }
        }

        private double b { get; set; }
        public double B
        {
            get => Math.Round(b, 3);
            set
            {
                if (value > 10 || value < 0) throw new ArgumentOutOfRangeException();
                b = value;
            }
        }

        private double c { get; set; }
        public double C
        {
            get => Math.Round(c, 3);
            set
            {
                if (value > 10 || value < 0) throw new ArgumentOutOfRangeException();
                c = value;
            }
        }

        public UnitOfMeasure Measure { get; set; }
          
        public Pudelko(double a = 10, double b = 10, double c = 10, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            A = a;
            B = b;
            C = c;
            Measure = unit;
        }
    }
}

