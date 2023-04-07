using System;
using System.Collections;

namespace MyLib
{
    public sealed partial class Pudelko : IEnumerable<double>
    {

        public IEnumerator<double> GetEnumerator()
        {
            yield return A;
            yield return B;
            yield return C;
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

