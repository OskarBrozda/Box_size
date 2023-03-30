using MyLib;
using P = MyLib.Pudelko;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Pudelko p1 = new Pudelko(9);
            Console.WriteLine($"{p1.A}, {p1.B}, {p1.C}, {p1.Measure}");
        }
    }
}
