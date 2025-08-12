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
            inventory.Add("BGLO", new InvItem(0, 0.49f, Type.Bagel));
            inventory.Add("BGLP", new InvItem(1, 0.39f, Type.Bagel));
            inventory.Add("BGLE", new InvItem(2, 0.49f, Type.Bagel));
            inventory.Add("BGLS", new InvItem(3, 0.49f, Type.Bagel));
            inventory.Add("FILB", new InvItem(4, 0.12f, Type.Filling));
            inventory.Add("FILE", new InvItem(5, 0.12f, Type.Filling));
            inventory.Add("FILC", new InvItem(6, 0.12f, Type.Filling));
            inventory.Add("FILX", new InvItem(7, 0.12f, Type.Filling));
            inventory.Add("FILS", new InvItem(8, 0.12f, Type.Filling));
            inventory.Add("FILH", new InvItem(9, 0.12f, Type.Filling));
            inventory.Add("COFB", new InvItem(10, 0.99f, Type.Coffee));
            inventory.Add("COFW", new InvItem(11, 1.19f, Type.Coffee));
            inventory.Add("COFC", new InvItem(12, 1.29f, Type.Coffee));
            inventory.Add("COFL", new InvItem(13, 1.29f, Type.Coffee));

        }

        public float getFillingCost(string fillingSKU )
        {
            return inventory[fillingSKU].Price;
        }

        public bool inInventory(string SKU)
        {
            return inventory.ContainsKey(SKU);
        }
    }
}
