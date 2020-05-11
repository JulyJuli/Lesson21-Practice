using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionSection
{
    public class CustomCollectionFromZero<T> : ICollection<T>
       where T : Section
    {
        protected IList<T> Items;
        public CustomCollectionFromZero()
        {
            Items = new List<T>();
        }
        public int Count => Items.Count;
        public T this[int index]=>Items[index];

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if(!string.IsNullOrEmpty(item.Name))
            {
                Items.Add(item);
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SectionEnumerator<T>(this);
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
