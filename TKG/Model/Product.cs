using System;

namespace TKG
{
    internal class Product
    {
        private int id;
        private int product_family_id;
        private String name;
        private int price;
        private int stock;
        private int state;

        public Product(int id, int product_family_id, string name, int price, int stock, int state)
        {
            this.id = id;
            this.product_family_id = product_family_id;
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.state = state;
        }
        public int Id { get => id; set => id = value; }
        public int Product_family_id { get => product_family_id; set => product_family_id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public int State { get => state; set => state = value; }
    }

}