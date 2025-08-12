using exercise.main;
using exercise.main.Products;

Inventory inventory = new Inventory();
Basket basket = new Basket(3, inventory);

Bagel bagel = new Bagel("BGLO", inventory);
Bagel bagel2 = new Bagel("BGLE", inventory);
Bagel bagel3 = new Bagel("BGLO", inventory);

bagel.addFilling(new Filling("FILE", inventory));
bagel.addFilling(new Filling("FILE", inventory));
bagel2.addFilling(new Filling("FILB", inventory));

basket.Add(bagel);
basket.Add(bagel2);
basket.Add(bagel3);

basket.getTotalPriceForAllFillings();

