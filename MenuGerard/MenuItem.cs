using System;


namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        private static int nextId = 1;
        public readonly int Id;
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        pulic MenuItem()
        {
            Id = nextId;
            nextId++;
        }

        public MenuItem(string name, double price, string description, string category)  
    }
}
