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
            IProduct bagel = new Bagel();
            basket.Add(bagel);

            Assert.That(basket.ProductList.Count == 1);


        }
    }
}
