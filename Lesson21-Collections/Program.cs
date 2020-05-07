using Lesson21_Collections.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //var sections = new CustomSections();

            //sections.Add(new Section() { Price = 10, Name = "Valley" });
            //sections.Add(new Section() { Price = -10, Name = "Footboal" });
            //sections.Add(new Section() { Price = 100, Name = "Ragby" });

            //Console.WriteLine(sections["Ragby"].Price);


            //sections.ForEach(Console.WriteLine);
            //sections.ForEach(WriteFile);

            var sections = new CustomCollectionFromZero<Section>();

            sections.Add(new Section() { Price = 10, Name = "Valley" });
            sections.Add(new Section() { Price = -10, Name = "" });
            sections.Add(new Section() { Price = 100, Name = "Ragby" });

            foreach (var item in sections)
            {
                Console.WriteLine(item.Name);   
            }


            Console.ReadKey();
        }

        static void WriteFile(string data)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\test.txt");
            file.WriteLine(data);

            file.Close();
        }
    }
}
