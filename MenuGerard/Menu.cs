using Microsoft.VisualBasic;
using Restaurant;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MenuGerard
{
    public class Menu
    {
        public List<MenuItem> Items { get; }
        public DateTime LastUpdated { get; set; }

        public Menu(List<MenuItem> items)
        {
            Items = items;
            LastUpdated = DateTime.Now;
        }

        public void Add(MenuItem item)
        {
            Items.Add(item);
            LastUpdated = DateTime.Now;
        }

        public void Remove()
        {
            Console.WriteLine("Choose an index number corresponding to the menu item which you wihs to remove.");
            this.PrintAllItems();
            int idx = Int32 / FileStyleUriParser(Console.ReadLine());
            Items.RemoveAt(idx);
            this.PrintAllItems();
            LastUpdated = DateTime.Now;
        }

        public void PrintAllItems() 
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"{i} - {Items[i].Name}: {Items[i].Description} ${Items[i].Price}");
                Console.WriteLine("-------------------\n");
                {

            }
        }

        public void ShowLastUpdate()
            {
                Console.WriteLine($"The menu was last updated on {LastUpdated}");
            }

    }
}
