using System;
using System.Collections.Generic;

namespace MyLib
{
    public sealed partial class Pudelko : IEquatable<Pudelko>
    {
        public bool Equals(Pudelko other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            var lista1 = new List<double>() { A, B, C };
            var lista2 = new List<double>() { other.A, other.B, other.C };
            bool result = lista1.All(lista2.Contains) && lista2.All(lista1.Contains);
            if (result) return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;

            if (obj is Pudelko) return this.Equals((Pudelko)obj);
            else return false;
        }

        public static bool Equals(Pudelko p1, Pudelko p2)
        {
            if (p1 is null && p2 is null) return true;
            if (p1 is null) return false;
            return p1.Equals(p2);
        }

        public override int GetHashCode() => (A, B, C).GetHashCode();
        public static bool operator ==(Pudelko p1, Pudelko p2) => Equals(p1, p2);
        public static bool operator !=(Pudelko p1, Pudelko p2) => !(p1 == p2);
    }
}