using exercise.main;
using exercise.main.Products;


Inventory inventory = new Inventory();
Basket basket = new Basket(20, inventory);
Bagel bagel = new Bagel("BGLO", inventory);
Bagel bagel2 = new Bagel("BGLE", inventory);
//basket.Add(bagel);
//basket.Add(bagel);
for (int i = 0; i < 20; i++)
{
    basket.Add(bagel2);
}



float total = basket.caluculateDiscount();
Console.WriteLine(total);