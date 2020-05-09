using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Collections.Utils
{
    public class CustomSections : Collection<Section>
    {
        public Section this[string name] => this.Items.First(s => s.Name.Equals(name));

        public IEnumerable<string> AllSectionsByName => this.Items.Select(s => s.Name);

        protected override void InsertItem(int index, Section item)
        {
            if (item.Price > 0)
            {
                base.InsertItem(index, item);
            } else {
                Console.WriteLine($"Price isn't valid: {item.Price}");
            }
        }

        public void ForEach(Action<string> action)
        {
            foreach (var item in Items)
            {
                action($"Selection name {item.Name}, price {item.Price}");
            }
        }
    }
}
