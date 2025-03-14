using System;

namespace TKG
{
    internal class ProductFamily
    {
        private int id;
        private String name;
        private int state;
        public ProductFamily(int id, string name, int state)
        {
            this.id = id;
            this.name = name;
            this.state = state;
        }
        public int Id { get => id; set => id = value; }
        public String Name { get => name; set => name = value; }
        public int State { get => state; set => state = value; }

    }
}
