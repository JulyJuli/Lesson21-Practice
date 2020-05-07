using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Less21_collection.Units
{
    public class CustomSections:Collection<Section>
    {
        public Section this[string name]=>this.Items.First(s=>string.Equals(s.Name,name));
        public IEnumerable<string> AllSectionsByName => this.Items.Select(s => s.Name);
        protected override void InsertItem(int index, Section item)
        {
            if (item.Cost > 0)
            {
                base.InsertItem(index, item);

            }
            else
            {
                Console.WriteLine($"Specified cost isn't valid: {item.Cost}");
            }
        }

        public void ForEach(Action<string> action)
        {
            foreach(var item in Items)
            {
                action($"Section name {item.Name} and cost {item.Cost}");
            }
        }

    }
}
