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
        public IEnumerable<string> AllSectionsByName => this.Items.Select(s => s.Name);

        public Section this[string name] => this.Items.First(s => s.Name == name);

        protected override void InsertItem(int index, Section item)
        {
            if(item.Cost > 0)
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
