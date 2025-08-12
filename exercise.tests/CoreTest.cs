using exercise.main;
using exercise.main.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class CoreTest
    {
        [Test]
        public void TestAdd()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            basket.Add(bagel);

            Assert.That(basket.ProductList.Count == 1);
        }

        [Test]
        public void TestRemove()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            basket.Add(bagel);

            basket.Remove(0);

            Assert.That(basket.ProductList.Count == 0);
        }

        [Test]
        public void TestIsFull()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLO", inventory);
            Bagel bagel3 = new Bagel("BGLO", inventory);

            basket.Add(bagel);
            Assert.IsFalse(basket.IsFull());
            basket.Add(bagel2);
            basket.Add(bagel3);
            Assert.IsTrue(basket.IsFull());

        }

        [Test]
        public void TestBasketSize()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Assert.That(basket.BasketSize == 3);
            basket.BasketSize = 6;
            Assert.That(basket.BasketSize == 6);
        }

        [Test]
        public void TestItemInBasket()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            basket.Add(bagel);

            Assert.IsTrue(basket.ItemInBasket("BGLO"));
        }

        [Test]
        public void TestGetBagelCost()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            //Bagel bagel = new Bagel("BGLO", inventory);

            Assert.That(basket.getBagelCost("BGLO") == 0.49f);
        }

        [Test]
        public void TestGetTotal()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLE", inventory);

            basket.Add(bagel);
            basket.Add(bagel2);

            Assert.That(basket.getTotalCost() == 0.98f);
        }

        [Test]
        public void TestGetTotalWithAddedFillings()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLE", inventory);

            basket.Add(bagel);
            bagel.addFilling(new Filling("FILE", inventory));
            basket.Add(bagel2);

            Assert.That(basket.getTotalCost() == 1.10f);
        }

        [Test]
        public void TestAddFilling()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            bagel.addFilling(new Filling("FILE", inventory));
            bagel.addFilling(new Filling("FILB", inventory));
            Assert.That(bagel.Fillings.Count == 2);
        }

        [Test]
        public void TestGetCostOfFilling()
        {
            Inventory inventory = new Inventory();

            Assert.That(inventory.getFillingCost("FILE") == 0.12f);
        }

        [Test]
        public void TestInInventory()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);

            Assert.IsTrue(inventory.inInventory("BGLO"));
            Assert.IsFalse(inventory.inInventory("egg"));
        }

        [Test]
        public void TestcostForFillings()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(3, inventory);

            Bagel bagel = new Bagel("BGLO", inventory);

            bagel.addFilling(new Filling("FILE", inventory));
            bagel.addFilling(new Filling("FILE", inventory));

            Assert.That(bagel.costForFillings() == 0.24f);


        }


        [Test]
        public void TestGetItemCount()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(15, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLE", inventory);
            basket.Add(bagel);
            basket.Add(bagel);
            for (int i = 0; i < 10; i++)
            {
                basket.Add(bagel2);
            }

            Dictionary<string, int> itemCount = basket.getItemCount();

            Assert.That(itemCount["BGLO"] == 2);
            Assert.That(itemCount["BGLE"] == 10);
        }

        [Test]
        public void TestGetTotalPriceForAllFillings()
        {
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


            Assert.That(basket.getTotalPriceForAllFillings() == 0.36f);
        }

        [Test]
        public void TestCheckIfBundleDealAvailable()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(15, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLE", inventory);
            basket.Add(bagel);
            basket.Add(bagel);
            for (int i = 0; i < 10; i++)
            {
                basket.Add(bagel2);
            }

            Dictionary<string, int> itemCount = basket.getItemCount();

            Assert.IsTrue(basket.checkIfBundleDealAvaiable(itemCount));
            Assert.IsFalse(basket.checkIfCoffeeDealAvailable(itemCount));
        }

        [Test]
        public void TestCheckIfCoffeeDealAvailable()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(15, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLE", inventory);
            basket.Add(bagel);
            basket.Add(bagel);
            basket.Add(new Coffee("COFB", inventory));

            Dictionary<string, int> itemCount = basket.getItemCount();

            Assert.IsFalse(basket.checkIfBundleDealAvaiable(itemCount));
            Assert.IsTrue(basket.checkIfCoffeeDealAvailable(itemCount));
        }

        [Test]
        public void TestCalculateDiscount()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(120, inventory);
            Bagel bagel2 = new Bagel("BGLE", inventory);
            for (int i = 0; i < 20; i++)
            {
                basket.Add(bagel2);
            }


            Assert.That(basket.caluculateDiscount() == 7.46f);


        }

        [Test]
        public void TestGetToalCostOfBagels()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(15, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLE", inventory);
            bagel.addFilling(new Filling("FILE", inventory));
            bagel.addFilling(new Filling("FILE", inventory));
            bagel2.addFilling(new Filling("FILE", inventory));
            basket.Add(bagel);
            basket.Add(bagel);
            basket.Add(new Coffee("COFB", inventory));
            for (int i = 0; i < 3; i++)
            {
                basket.Add(bagel2);
            }

            Assert.That(basket.getTotalCostForBagels() == 2.45f);

        }

        [Test]
        public void TestDiscounts1()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(30, inventory);
            Bagel bagel = new Bagel("BGLO", inventory);
            Bagel bagel2 = new Bagel("BGLP", inventory);
            Bagel bagel3 = new Bagel("BGLE", inventory);
            Coffee coffee = new Coffee("COFB", inventory);
            basket.Add(bagel);
            basket.Add(bagel);
            for (int i = 0; i < 12; i++)
            {
                basket.Add(bagel2);
            }
            for (int i = 0; i < 6; i++)
            {
                basket.Add(bagel3);
            }
            for (int i = 0; i < 3; i++)
            {
                basket.Add(coffee);
            }

            Assert.That(basket.caluculateDiscount() == 10.43f);
        }
        [Test]
        public void TestDiscounts2()
        {
            Inventory inventory = new Inventory();
            Basket basket = new Basket(30, inventory);
            Bagel bagel = new Bagel("BGLP", inventory);
            for (int i = 0; i < 16; i++)
            {
                basket.Add(bagel);
            }


            Assert.That(basket.caluculateDiscount() == 5.55f);
        }

        [Test]
        public void TestDiscounts3()
        {
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

            Assert.That(basket.caluculateDiscount() == 3.28f);

        }
    }
}
