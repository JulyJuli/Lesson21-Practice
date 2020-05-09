using System.Collections;
using System.Collections.Generic;

namespace Collections.Utils
{
    public class SectionEnumerator<T> : IEnumerator<T> where T : Section
    {
        public int Counter = -1;

        private readonly CustomCollectionFromZero<T> collection;

        public SectionEnumerator(CustomCollectionFromZero<T> collection)
        {
            this.collection = collection;
        }


        public bool MoveNext()
        {
            ++Counter;
            if (collection.Count > Counter)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Counter = -1;
        }

        public T Current => collection[Counter];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Counter = -1;
        }
    }
}
