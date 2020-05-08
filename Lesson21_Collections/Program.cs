using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson21_Collections.Utils;

namespace Lesson21_Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var sections = new CustomSections();

            //sections.Add(new Section() { Cost = 10, Name = "Volleyball" });
            //sections.Add(new Section() { Cost = -10, Name = "Football" });
            //sections.Add(new Section() { Cost = 100, Name = "Ragby" });

            //sections.ForEach(Console.WriteLine);

            var sections = new CustomCollectionFromScratch<Section>();

            sections.Add(new Section() { Cost = 10, Name = "Volleyball" });
            sections.Add(new Section() { Cost = -10, Name = "Football" });
            sections.Add(new Section() { Cost = 100, Name = "Ragby" });

            foreach(var item in sections)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
