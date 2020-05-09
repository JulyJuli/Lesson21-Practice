using System;
using Collections.Utils;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testSections = new CustomSections();

            testSections.Add(new Section{ Price = 100, Name = "test001"});
            testSections.Add(new Section{ Price = -100, Name = "test002"});
            testSections.Add(new Section{ Price = 10, Name = "test003"});

            testSections.ForEach(Console.WriteLine);

            Console.WriteLine("========================");

            var sections = new CustomCollectionFromZero<Section>();

            sections.Add(new Section{ Price = 100, Name = "test001"});
            sections.Add(new Section{ Price = -100, Name = ""});
            sections.Add(new Section{ Price = 10, Name = "test003"});

            foreach (var item in sections)
            {
                Console.WriteLine($"Name = {item.Name}, price = {item.Price}");
            }

        }
    }
}
