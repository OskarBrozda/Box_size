using MyLib;
using P = MyLib.Pudelko;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctor's, zaokrąglanie
            Console.WriteLine("Tworzenie pudełek + zaokraglanie wyników");

            Pudelko p1 = new Pudelko(140, 150, 140, UnitOfMeasure.centimeter); 
            Console.WriteLine($"1  >>  A = {p1.A}     B = {p1.B}    C = {p1.C}");  

            Pudelko p2 = new Pudelko(0.1, 30, unit: UnitOfMeasure.centimeter); 
            Console.WriteLine($"2  >>  A = {p2.A}   B = {p2.B}    C = {p2.C}");

            Pudelko p3 = new Pudelko(5.26, 5, 5, UnitOfMeasure.centimeter); 
            Console.WriteLine($"3  >>  A = {p3.A}   B = {p3.B}   C = {p3.C}");

            Pudelko p4 = new Pudelko(1, 2, 3);
            Console.WriteLine($"4  >>  A = {p4.A}       B = {p4.B}      C = {p4.C}");

            Pudelko p5 = new Pudelko(1.4, 1.5, 1.4, UnitOfMeasure.meter);
            Console.WriteLine($"5  >>  A = {p5.A}     B = {p5.B}    C = {p5.C}");


            //ToString
            Console.WriteLine();
            Console.WriteLine("ToString");
            Console.WriteLine(p5.ToString("cm"));
            Console.WriteLine(p5.ToString("mm"));
            Console.WriteLine(p1.ToString(null));


            //Pole i Objętość
            Console.WriteLine();
            Console.WriteLine("Pole i objętość");
            Console.WriteLine("P = " + p5.Pole);
            Console.WriteLine("V = " + p5.Objetosc);


            //Equals
            Console.WriteLine();
            Console.WriteLine("Równość pudełek");
            Console.WriteLine(p1 == p5);
            Console.WriteLine(p1.Equals(p2));


            //dodawanie
            Console.WriteLine();
            Console.WriteLine("Dodawanie pudełek");


            //konwersja z ValueTuple
            Console.WriteLine();
            Console.WriteLine("Konwersja z ValueTuple");
            var (a, b, c, d) = (2500, 9321, 100, UnitOfMeasure.milimeter);
            Pudelko p6 = (a, b, c, d);
            Console.WriteLine($"A = {p6.A}, B = {p6.B}, C = {p6.C}");


            //indexer i iterator
            Console.WriteLine();
            Console.WriteLine("Indexer i iterator");
            Console.WriteLine("p2[1] = " + p2[1]);
            Console.WriteLine("p1: ");
            foreach (var item in p1)
                Console.WriteLine(item);


            //parsowanie
            Console.WriteLine();
            Console.WriteLine("Parsowanie");
            Pudelko p7 = P.Parse("250.0 cm × 932.1 cm × 10.0 cm");
            Console.WriteLine(p5.ToString("cm"));

            //kompresja
            Console.WriteLine();
            Console.WriteLine("Kompresja");
            Pudelko p8 = p7.Kompresuj();
            Console.WriteLine(p8.ToString());


            //lista pudełek - sortowanie
            Console.WriteLine();
            Console.WriteLine("Lista pudełek przed sortowaniem:");
            List<Pudelko> lista3 = new List<Pudelko>();
            lista3.Add(new Pudelko(2, 3, 4));
            lista3.Add(new Pudelko(2.5, 4, 4.5, UnitOfMeasure.centimeter));
            lista3.Add(new Pudelko(3, 3, 3, UnitOfMeasure.milimeter));
            lista3.Add(new Pudelko(1, 1, 10));
            foreach (var item in lista3)
                Console.WriteLine(item);

            Comparison<Pudelko> porownajPudelka = delegate (Pudelko p1, Pudelko p2)
            {
                if (p1.Objetosc < p2.Objetosc) return -1;
                else if (p1.Objetosc > p2.Objetosc) return 1;
                else
                {
                    if (p1.Pole < p2.Pole) return -1;
                    else if (p1.Pole > p2.Pole) return 1;
                    else
                    {
                        if ((p1.A + p1.B + p1.C) < (p2.A + p2.B + p2.C)) return -1;
                        else if ((p1.A + p1.B + p1.C) > (p2.A + p2.B + p2.C)) return 1;
                        else return 0;
                    }
                }
            };
            lista3.Sortuj(porownajPudelka);

            Console.WriteLine();
            Console.WriteLine("Lista pudełek po sortowaniu:");
            foreach (var item in lista3)
                Console.WriteLine(item);
        }
    }
}
