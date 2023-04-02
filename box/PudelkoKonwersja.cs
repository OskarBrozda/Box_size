using System;

namespace MyLib
{
	public partial class Pudelko
	{
        public override string ToString()
        {
            return string.Format($"{A:N3} m × {B:N3} m × {C:N3} m (P = {Pole} m², V = {Objetosc} m³)");
        }

        public string ToString(ShortUnitOfMeasure format)
        {
            switch (format)
            {
                case (ShortUnitOfMeasure.m): return string.Format($"{A:N3} m × {B:N3} m × {C:N3} m (P = {Pole} m², V = {Objetosc} m³)");
                case (ShortUnitOfMeasure.cm): return string.Format($"{A * 100:N1} cm × {B * 100:N1} cm × {C * 100:N1} cm (P = {Pole * 10000} cm², V = {Objetosc * 1000000} cm³)");
                case (ShortUnitOfMeasure.mm): return string.Format($"{A * 1000:N0} mm × {B * 1000:N0} mm × {C * 1000:N0} mm (P = {Pole * 1000000} mm², V = {Objetosc * 1000000000} mm³)");
            }
            throw new FormatException("Podano błędny format");
        }
    }
}