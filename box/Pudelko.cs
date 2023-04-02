using System;
using System.Linq;

namespace MyLib
{
    public partial class Pudelko
    {
        private double a;
        public double A { get => Math.Round(a, 3, MidpointRounding.ToZero); }

        private double b;
        public double B { get => Math.Round(b, 3, MidpointRounding.ToZero); }

        private double c;
        public double C { get => Math.Round(c, 3, MidpointRounding.ToZero); }

        private double objetosc;
        public double Objetosc { get => Math.Round(objetosc, 9, MidpointRounding.ToZero); }

        private double pole;
        public double Pole { get => Math.Round(pole, 6, MidpointRounding.ToZero); }

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
            
            if (a * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.a = a * multiplier;
            if (b * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.b = b * multiplier;
            if (c * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.c = c * multiplier;

            objetosc = a * b * c * Math.Pow(multiplier, 3);
            pole = 2 * a * b * Math.Pow(multiplier, 2) + 2 * a * c * Math.Pow(multiplier, 2) + 2 * b * c * Math.Pow(multiplier, 2);
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
            
            if (a * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.a = a * multiplier;
            if (b * multiplier > 10) throw new ArgumentOutOfRangeException("Wymiary pudełka nie mogą przekroczyć 10m.");
            this.b = b * multiplier;
            
            this.c = c * multiplier;
            objetosc = a * b * c * Math.Pow(multiplier, 3);
            pole = 2 * a * b * Math.Pow(multiplier, 2) + 2 * a * c * Math.Pow(multiplier, 2) + 2 * b * c * Math.Pow(multiplier, 2);
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
            objetosc = a * b * c * Math.Pow(multiplier, 3);
            pole = 2 * a * b * Math.Pow(multiplier, 2) + 2 * a * c * Math.Pow(multiplier, 2) + 2 * b * c * Math.Pow(multiplier, 2);
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

            objetosc = a * b * c * Math.Pow(multiplier, 3);
            pole = 2 * a * b * Math.Pow(multiplier, 2) + 2 * a * c * Math.Pow(multiplier, 2) + 2 * b * c * Math.Pow(multiplier, 2);
        }
        #endregion Ctor's
    }
}

