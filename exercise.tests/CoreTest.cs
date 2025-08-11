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
            Basket basket = new Basket(3,inventory);
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
            Bagel bagel = new Bagel("BGLO",inventory);
            Bagel bagel2 = new Bagel("BGLO",inventory);
            Bagel bagel3 = new Bagel("BGLO",inventory);

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


    }
}
