using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sections = new CustomerSections();
            sections.Add(new Section() { Cost = 10, Name = "Voleyball" });
            sections.Add(new Section() { Name = "Football", Cost = -10 });
            sections.Add(new Section() { Cost = 150, Name = "Regbi" });

            sections.ForEach(Console.WriteLine);
            sections.ForEach(WritToFile);
        }
    
            static void WritToFile(string data)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\test1.txt");
            file.WriteLine(data);
            file.Close();
        }

            
            
        
    }
}
