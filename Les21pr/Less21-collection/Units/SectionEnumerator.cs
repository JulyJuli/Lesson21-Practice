using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less21_collection.Units
{
    public class SectionEnumerator<T> : IEnumerator<T>
        where T : Section
    {

        public int Counter = -1;

        private readonly CustomCollectionFromZero<T> collection;

        public SectionEnumerator(CustomCollectionFromZero<T> collection)
        {
            this.collection = collection;
        }



        public T Current => collection[Counter];

        object IEnumerator.Current => collection[Counter];

        public void Dispose()
        {
            Counter =-1;
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
