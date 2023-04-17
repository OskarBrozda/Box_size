using System;

namespace MyLib
{
    public sealed partial class Pudelko
    {
        public override string ToString()
        {
            return $"{A:N3} m × {B:N3} m × {C:N3} m";
        }

        public string ToString(string format)
        {
            switch (format)
            {
                case (null): return ToString();
                case ("m"): return ToString();
                case ("cm"): return $"{A * 100:N1} cm × {B * 100:N1} cm × {C * 100:N1} cm";
                case ("mm"): return $"{A * 1000:N0} mm × {B * 1000:N0} mm × {C * 1000:N0} mm";
            }
            throw new FormatException("Podano błędny format");
        }

        public static explicit operator double[](Pudelko p)
        {
            double[] tab = { p.A, p.B, p.C };
            return tab;
        }

        public static implicit operator Pudelko(ValueTuple<int, int, int> vT) => new Pudelko(vT.Item1, vT.Item2, vT.Item3);
        public static implicit operator Pudelko(ValueTuple<int, int, int, UnitOfMeasure> vT) => new Pudelko(vT.Item1, vT.Item2, vT.Item3, vT.Item4);

        public static Pudelko Parse(string text)
        {
            string[] textParts = text.Replace(" × ", " ").Split(" ", StringSplitOptions.RemoveEmptyEntries);
            switch (textParts[1])
            {                
                case ("m"): return new Pudelko(double.Parse(textParts[0]), double.Parse(textParts[2]), double.Parse(textParts[4]), UnitOfMeasure.meter);
                case ("cm"): return new Pudelko(double.Parse(textParts[0]), double.Parse(textParts[2]), double.Parse(textParts[4]), UnitOfMeasure.centimeter);
                case ("mm"): return new Pudelko(double.Parse(textParts[0]), double.Parse(textParts[2]), double.Parse(textParts[4]), UnitOfMeasure.milimeter);
                default: throw new Exception("Błędny format zapisu");
            }
        }
    }
}