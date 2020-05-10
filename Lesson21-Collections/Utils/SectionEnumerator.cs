using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Collections.Utils
{
    public class SectionEnumerator<T> : IEnumerator<T> where T : Section
    {
        public int Counter = -1;

        private readonly CustomCollectionFromZero<T> collection;

        public SectionEnumerator(CustomCollectionFromZero<T> collectioolln)
        {
            this.collection = collectioolln;
        }


        public T Current => collection[Counter];

        object IEnumerator.Current => collection[Counter];

        public void Dispose()
        {
            Counter = -1;
        }

        public bool MoveNext()
        {
            ++Counter;
            if(collection.Count > Counter)
            {
                return true;
            }
            else {return false; }
        }

        public void Reset()
        {
            Counter = -1;
        }
    }
}
