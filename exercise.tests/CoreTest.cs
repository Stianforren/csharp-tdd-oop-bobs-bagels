using exercise.main;
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
            Bagel bagel = new Bagel();
            basket.Add(bagel);

            Assert.That(basket.ProductList.Count == 1);
        }

        [Test]
        public void TestRemove()
        {
            Basket basket = new Basket(3);
            Bagel bagel = new Bagel();
            basket.Add(bagel);

            basket.Remove(0);

            Assert.That(basket.ProductList.Count == 0);
        }

        [Test]
        public void TestIsFull()
        {
            Basket basket = new Basket(3);
            Bagel bagel = new Bagel();
            Bagel bagel2 = new Bagel();
            Bagel bagel3 = new Bagel();

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
    }
}
