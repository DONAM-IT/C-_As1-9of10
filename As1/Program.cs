using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string exit = "";
            ArrayList menu = new ArrayList();
            menu.Add("*****************Welcome to item management****************");
            menu.Add("*       1. Add new item                                   *");
            menu.Add("*       2. Update item                                    *");
            menu.Add("*       3. Delete item                                    *");
            menu.Add("*       4. Search for a item by the item's code           *");
            menu.Add("*       5. Display items in ascending order of price      *");
            menu.Add("*       6. Quit                                           *");
            menu.Add("***********************************************************");
            Manager quanlyItem = new Manager();
            do
            {
                do
                {
                    Console.WriteLine("                   =====================           ");
                    foreach (string show in menu)
                    {
                        Console.WriteLine(show);
                    }
                    choice = CheckInput.InputInt("Enter Your Choice : ");
                    if (choice < 1 || choice > 6) Console.WriteLine("Choice from 1 to 6");
                    else if (choice == 6)
                    {
                        // Console.WriteLine("Thanks you, see you again !!!")
                        //break;
                    }
                } while (choice < 1 || choice > 6 || (string.Compare(exit, "n", true) == 0 && choice == 6));
                switch (choice)
                {
                    case 1:
                        quanlyItem.addItem();
                        break;
                    case 2:
                        quanlyItem.updateItem();
                        break;
                    case 3:
                        quanlyItem.deleteItem();
                        break;
                    case 4:
                        quanlyItem.searchItem();
                        break;
                    case 5:
                        quanlyItem.showItem();
                        break;
                }
            } while (choice != 6);
        }
    }
}
