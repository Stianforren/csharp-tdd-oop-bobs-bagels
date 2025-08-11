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
            Basket basket = new Basket(3);
            Bagel bagel = new Bagel("BGLO");
            basket.Add(bagel);

            Assert.That(basket.ProductList.Count == 1);
        }

        [Test]
        public void TestRemove()
        {
            Basket basket = new Basket(3);
            Bagel bagel = new Bagel("BGLO");
            basket.Add(bagel);

            basket.Remove(0);

            Assert.That(basket.ProductList.Count == 0);
        }

        [Test]
        public void TestIsFull()
        {
            Basket basket = new Basket(3);
            Bagel bagel = new Bagel("BGLO");
            Bagel bagel2 = new Bagel("BGLO");
            Bagel bagel3 = new Bagel("BGLO");

            basket.Add(bagel);
            Assert.IsFalse(basket.IsFull());
            basket.Add(bagel2);
            basket.Add(bagel3);
            Assert.IsTrue(basket.IsFull());

        }

        [Test]
        public void TestBasketSize()
        {
            Basket basket = new Basket(3);
            Assert.That(basket.BasketSize == 3);
            basket.BasketSize = 6;
            Assert.That(basket.BasketSize == 6);
        }

        [Test]
        public void TestItemInBasket()
        {
            Basket basket = new Basket(3);
            Bagel bagel = new Bagel("BGLO");
            basket.Add(bagel);

            Assert.IsTrue(basket.ItemInBasket("BGLO"));
        }

        [Test]
        public void TestGetBagelCost()
        {
            Basket basket = new Basket(3);
            Bagel bagel = new Bagel("BGLO");

            Assert.That(basket.getBagelCost("BGLO") == 0.49f);
        }
    }
}
