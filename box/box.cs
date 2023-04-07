using System;
using System.Linq;

namespace MyLib
{
    public sealed partial class Pudelko
    {
        private readonly double a;
        public double A { get => Math.Round(a, 3, MidpointRounding.ToZero); }

        private readonly double b;
        public double B { get => Math.Round(b, 3, MidpointRounding.ToZero); }

        private readonly double c;
        public double C { get => Math.Round(c, 3, MidpointRounding.ToZero); }

        private readonly double objetosc;
        public double Objetosc { get => Math.Round(A * B * C, 9, MidpointRounding.ToZero); }

        private readonly double pole;
        public double Pole { get => Math.Round(2* (A * B + A * C + B * C), 6, MidpointRounding.ToZero); }

        public double this[int index]
        {
            get
            {
                if (index == 0) return Math.Round(A, 3, MidpointRounding.ToZero);
                else if (index == 1) return Math.Round(B, 3, MidpointRounding.ToZero);
                else if (index == 2) return Math.Round(C, 3, MidpointRounding.ToZero);
                else throw new ArgumentOutOfRangeException("Nieprawidłowy indeks.");
            }
        }

        #region Ctor's
        public Pudelko(double a, double b, double c, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            double multiplier;
            switch (unit)
            {
                case UnitOfMeasure.milimeter:
                    multiplier = 0.001;
                    break;
                case UnitOfMeasure.centimeter:
                    multiplier = 0.01;
                    break;
                case UnitOfMeasure.meter:
                    multiplier = 1.0;
                    break;
                default:
                    throw new ArgumentException("Nieznana jednostka miary.");
            }

            if (Math.Round(a*multiplier, 3, MidpointRounding.ToZero) <= 0 || Math.Round(b * multiplier, 3, MidpointRounding.ToZero) <= 0 || Math.Round(c * multiplier, 3, MidpointRounding.ToZero) <= 0) throw new ArgumentOutOfRangeException("Wymiary pudełka muszą być większe lub równe 1mm.");
            
            if (a * multiplier > 10 || b * multiplier > 10 || c * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.a = a * multiplier;
            this.b = b * multiplier;
            this.c = c * multiplier;
        }

        public Pudelko(double a, double b, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            double c;
            double multiplier;
            switch (unit)
            {
                case UnitOfMeasure.milimeter:
                    multiplier = 0.001;
                    c = 100;
                    break;
                case UnitOfMeasure.centimeter:
                    multiplier = 0.01;
                    c = 10;
                    break;
                case UnitOfMeasure.meter:
                    multiplier = 1.0;
                    c = 0.1;
                    break;
                default:
                    throw new ArgumentException("Nieznana jednostka miary.");
            }

            if (Math.Round(a * multiplier, 3, MidpointRounding.ToZero) <= 0 || Math.Round(b * multiplier, 3, MidpointRounding.ToZero) <= 0) throw new ArgumentOutOfRangeException("Wymiary pudełka muszą być większe lub równe 1mm.");
            
            if (a * multiplier > 10 || b * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.a = a * multiplier;
            this.b = b * multiplier;            
            this.c = c * multiplier;
        }

        public Pudelko(double a, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            double b, c;
            double multiplier;
            switch (unit)
            {
                case UnitOfMeasure.milimeter:
                    multiplier = 0.001;
                    c = b = 100;
                    break;
                case UnitOfMeasure.centimeter:
                    multiplier = 0.01;
                    c = b = 10;
                    break;
                case UnitOfMeasure.meter:
                    multiplier = 1.0;
                    c = b = 0.1;
                    break;
                default:
                    throw new ArgumentException("Nieznana jednostka miary.");
            }

            if (Math.Round(a * multiplier, 3, MidpointRounding.ToZero) <= 0) throw new ArgumentOutOfRangeException("Wymiary pudełka muszą być większe lub równe 1mm.");
           
            if (a * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.a = a * multiplier;            
            this.b = b * multiplier;
            this.c = c * multiplier;
        }

        public Pudelko(UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            double a, b, c;
            double multiplier;
            switch (unit)
            {
                case UnitOfMeasure.milimeter:
                    multiplier = 0.001;
                    a = c = b = 100;
                    break;
                case UnitOfMeasure.centimeter:
                    multiplier = 0.01;
                    a = c = b = 10;
                    break;
                case UnitOfMeasure.meter:
                    multiplier = 1.0;
                    a = c = b = 0.1;
                    break;
                default:
                    throw new ArgumentException("Nieznana jednostka miary.");
            }
            this.a = a * multiplier;
            this.b = b * multiplier;
            this.c = c * multiplier;
        }
        #endregion Ctor's
    }
}

