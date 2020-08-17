using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As1
{
    class Manager
    {
        public List<Item> ls = new List<Item>();
        public int check(string codeItem)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].CodeItem.Equals(codeItem)) return i;
            }
            return -1;
        }
        public void addItem()
        {
            string codeItem, nameItem;
            float price;
            if (ls.Count == 50)
            {
                Console.WriteLine("     >>> List Full <<<");
                return;
            }
            codeItem = CheckInput.InputString("Enter CodeItem: ");
            if (check(codeItem) >= 0)
            {
                Console.WriteLine("    >>> CodeItem Exited!! <<<");
                return;
            }
            nameItem = CheckInput.InputString("Input Name Item: ");
            price = CheckInput.InputFloat("Input Price Of Item: ");

            ls.Add(new Item(codeItem, nameItem, price));
            Console.WriteLine("     >>> Add Item Successed <<<");
        }
        public void showItem()
        {
           ls.Sort();
            if (ls.Count == 0)
            {
                Console.WriteLine("     >>> List Item Empty <<<");
                return;
            }
            foreach (Item it in ls)
            {
                it.ShowInfo();
            }
        }
        public void searchItem()
        {
            string codeItem;
            if (ls.Count == 0)
            {
                Console.WriteLine("     >>>  List Items Empty <<<");
                return;
            }
            codeItem = CheckInput.InputString("Enter CodeItem : ");
            if (check(codeItem) < 0)
            {
                Console.WriteLine("     >>> Item {0} didn't Existed <<<", codeItem);
                return;
            }
            ls[check(codeItem)].ShowInfo();
        }
        public void updateItem()
        {
            string codeItem;
            float price;
            if (ls.Count == 0)
            {
                Console.WriteLine("     >>> List Items Empty <<<");
                return;
            }
            codeItem = CheckInput.InputString("Input CodeItem: ");
            if (check(codeItem) < 0)
            {
                Console.WriteLine("Item {0} didn't Existed ", codeItem);
                return;
            }
           
            price = CheckInput.InputFloat("Input Price Item: ");
            ls[check(codeItem)].Price = price;

            Console.WriteLine("     >>> Info Item {0} Update Success <<<", codeItem);
        }
        public void deleteItem()
        {
            String codeItem;
            codeItem = CheckInput.InputString("Input CodeItem to Delete: ");
            if (check(codeItem) < 0)
            {
                Console.WriteLine("Item {0} didn't Existed ", codeItem);
                return;
            }
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].CodeItem.Equals(codeItem))
                {
                    ls.Remove(ls[i]);
                }
            }
            Console.WriteLine("     >>> Delete Item Successed <<<");
        }
    }
}
