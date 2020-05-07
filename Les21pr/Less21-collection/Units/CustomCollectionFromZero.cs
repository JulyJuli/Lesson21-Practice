using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less21_collection.Units
{
    public class CustomCollectionFromZero<T>: ICollection<T>
        where T: Section
    {
        protected IList<T> Items;

        public CustomCollectionFromZero()
        {
            Items = new List<T>();
        }

        public int Count => Items.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index]=>(T)Items[index];
        public void Add(T item)
        {
            if (!string.IsNullOrEmpty(item.Name))
            {
                this.Items.Add(item);
            }
        }
        public void Clear()
        {
            Items.Clear();
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
