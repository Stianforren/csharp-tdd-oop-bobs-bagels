using exercise.main;
using exercise.main.Products;


Inventory inventory = new Inventory();
Basket basket = new Basket(30, inventory);
Bagel bagel = new Bagel("BGLP", inventory);
Coffee coffee = new Coffee("COFB", inventory);
for (int i = 0; i < 4; i++)
{
    basket.Add(bagel);
}
for (int i = 0; i < 2; i++)
{
    basket.Add(coffee);
}
Console.WriteLine(basket.caluculateDiscount());