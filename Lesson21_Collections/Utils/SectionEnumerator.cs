using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Collections.Utils
{
    public class SectionEnumerator<T> : IEnumerator<T>
        where T : Section
    {
        public int Counter = -1;

        private readonly CustomCollectionFromScratch<T> collection;

        public SectionEnumerator(CustomCollectionFromScratch<T> collection)
        {
            this.collection = collection;
        }

        public T Current => collection[Counter];

        object IEnumerator.Current => throw new NotImplementedException();

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
            return false;
        }

        public void Reset()
        {
            Counter = -1;
        }
    }
}
