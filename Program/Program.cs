using MyLib;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Pudelko p1 = new Pudelko();  // pudełko o wymiarach 10 cm x 10 cm x 10 cm (domyślne)
            Console.WriteLine($"A = {p1.A}, B = {p1.B}, C = {p1.C}");  // A = 0.01, B = 0.01, C = 0.01

            Pudelko p2 = new Pudelko(0.1, 30, unit: UnitOfMeasure.centimeter);  // pudełko o wymiarach 20 cm x 30 cm x 10 cm
            Console.WriteLine($"A = {p2.A}, B = {p2.B}, C = {p2.C}");  // A = 0.2, B = 0.3, C = 0.1

            Pudelko p3 = new Pudelko(5.26, 5, 5, UnitOfMeasure.centimeter);  // pudełko o wymiarach 5 cm x 5 cm x 5 cm
            Console.WriteLine($"A = {p3.A}, B = {p3.B}, C = {p3.C}");  // A = 0.05, B = 0.05, C = 0.05

            Pudelko p4 = new Pudelko(1, 2, 3);
            Console.WriteLine(p1.ToString(ShortUnitOfMeasure.cm));
        }
    }
}
