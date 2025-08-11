using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Inventory
    {
        public Dictionary<string, InvItem> inventory = new Dictionary<string, InvItem>();


        public Inventory()
        {
            inventory.Add("BGLO", new InvItem(0, 0.49f));
            inventory.Add("BGLP", new InvItem(1, 0.39f));
            inventory.Add("BGLE", new InvItem(2, 0.49f));
            inventory.Add("BGLS", new InvItem(3, 0.49f));
            inventory.Add("FILB", new InvItem(4, 0.12f));
            inventory.Add("FILE", new InvItem(5, 0.12f));
            inventory.Add("FILC", new InvItem(6, 0.12f));
            inventory.Add("FILX", new InvItem(7, 0.12f));
            inventory.Add("FILS", new InvItem(8, 0.12f));
            inventory.Add("FILH", new InvItem(9, 0.12f));

        }
    }
}
