using System.Collections;
using System.Collections.Generic;

namespace CollectionSection
{
    public class SectionEnumerator<T> : IEnumerator<T>
       where T : Section
    {
        public int counter = -1;
        private readonly CustomCollectionFromZero<T> collection;//
        public SectionEnumerator(CustomCollectionFromZero<T> collection)//
        {
            this.collection = collection;
        }
        public T Current => collection[counter];

        object IEnumerator.Current => collection[counter];

        public void Dispose()
        {
            counter = -1;
        }

        public bool MoveNext()
        {
            ++counter;
            if(collection.Count>counter)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            counter = -1;
        }
    }
}
