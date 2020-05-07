using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Collections.Utils
{
    public class CustomSections : Collection<Section>
    {
        public Section this[string name] => this.Items.First(s => string.Equals(s.Name, name));

        public IEnumerable<string> AllSectionsByName => this.Select(i => i.Name);

        protected override void InsertItem(int index, Section item)
        {
            if (item.Price > 0)
            {
                base.InsertItem(index, item);
            }
            else
            {
                Console.WriteLine($"Specified cost isn't valid: {item.Price}");
            }
        }

        public void ForEach (Action<string> action)
        {
            foreach (var item in Items)
            {
                action($"Section name {item.Name} and cost {item.Price}");
            }
        }
    }
}
