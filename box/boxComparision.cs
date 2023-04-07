using System;
using System.Diagnostics.Contracts;

namespace MyLib
{
    public static class Sortowanie
    {
        public static void SwapElements<T>(this IList<T> lista, int e1, int e2)
        {
            Contract.Requires(lista != null);
            Contract.Requires(e1 >= 0 && e1 < lista.Count);
            Contract.Requires(e2 >= 0 && e2 < lista.Count);
            if (e1 == e2) return;
            var temp = lista[e1];
            lista[e1] = lista[e2];
            lista[e2] = temp;
        }

        public static void Sortuj<Pudelko>(this List<Pudelko> lista, Comparison<Pudelko> comparision)
        {
            int n = lista.Count;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (comparision(lista[i], lista[i + 1]) > 0)
                    {
                        lista.SwapElements(i, i + 1);
                    }
                }
                n--;
            }
            while (n > 1);
        }
    }
}

