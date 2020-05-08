using Collections.Utils;
using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sections = new CustomSections();

            //sections.Add(new Section() { Cost = 10, Name = "Valleyball" });
            //sections.Add(new Section() { Cost = -10, Name = "Football" });
            //sections.Add(new Section() { Cost = 10, Name = "Ragby" });

            //sections.ForEach(Console.WriteLine);

            var sections = new CustomCollectionFromZero<Section>();

            sections.Add(new Section() { Cost = 10, Name = "Valleyball" });
            sections.Add(new Section() { Cost = -10, Name = "" });
            sections.Add(new Section() { Cost = 10, Name = "Ragby" });

            foreach (var item in sections)
            {
                Console.WriteLine(item.Name);
            }


            Console.ReadKey();
        }
    }
}
