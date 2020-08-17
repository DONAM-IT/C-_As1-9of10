using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As1
{
    class Item : IComparable<Item>
    {
        private String codeItem, nameItem;
        private float price;
        public Item()
        {

        }
        public Item(String codeItem , String nameItem, float price)
        {
            this.codeItem = codeItem;
            this.nameItem = nameItem;
            this.price = price;
        }
        

        public string CodeItem { get => codeItem; set => codeItem = value; }
        public string NameItem { get => nameItem; set => nameItem = value; }
        public float Price { get => price; set => price = value; }

        public void ShowInfo()
        {
            Console.WriteLine("CodeItem: {0}    -   NameItem: {1}  -   Price: {2} ", codeItem, nameItem, price);
        }

        public int CompareTo(Item other) 
        {
            return this.price.CompareTo(other.Price);
        }
    }
}
