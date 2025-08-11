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
    }
}
