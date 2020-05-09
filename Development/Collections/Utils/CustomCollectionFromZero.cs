using System.Collections;
using System.Collections.Generic;

namespace Collections.Utils
{
    public class CustomCollectionFromZero<T> : ICollection<T> where T : Section
    {
        protected IList<T> Items;

        public CustomCollectionFromZero()
        {
            Items = new List<T>();
        }


        public void Add(T item)
        {
            if (!string.IsNullOrEmpty(item.Name))
            {
                Items.Add(item);
            }
        }

        public int Count => Items.Count;
        public bool IsReadOnly { get; }


        public IEnumerator<T> GetEnumerator()
        {
            return new SectionEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }


        public T this[int counter]
        {
            get => Items[counter];
        }
    }
}
