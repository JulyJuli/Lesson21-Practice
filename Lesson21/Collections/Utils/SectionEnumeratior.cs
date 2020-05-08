using System.Collections;
using System.Collections.Generic;

namespace Collections.Utils
{
    public class SectionEnumeratior<T> : IEnumerator<T>
        where T : Section
    {
        public int Counter = -1;

        private readonly CustomCollectionFromZero<T> collection;

        public SectionEnumeratior(CustomCollectionFromZero<T> collection)
        {
            this.collection = collection;
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
    }
}
