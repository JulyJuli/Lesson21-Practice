using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less21_collection.Units;

namespace Less21_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sections = new CustomSections();

            //sections.Add(new Section(){ Cost = 10, Name = "Volleyball"});
            //sections.Add(new Section(){ Cost = -10, Name = "Football"});
            //sections.Add(new Section(){ Cost = 100, Name = "Ragby"});    

            var sections = new CustomCollectionFromZero<Section>();

            sections.Add(new Section() { Cost = 10, Name = "Volleyball" });
            sections.Add(new Section() { Cost = -10, Name = "Football" });
            sections.Add(new Section() { Cost = 100, Name = "Ragby" });

            foreach(var item in sections)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void WriteToFile(string data)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\test.txt");
            file.WriteLine(data);

            file.Close();
        }

    }
}
