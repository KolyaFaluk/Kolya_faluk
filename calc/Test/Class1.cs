using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using calc;

namespace Test
{
    public class Class1
    {
        [Test]
    public void SumTest()
        {
            Assert.AreEqual(5, new calc.vichisleniya().vichislenie(2, 3, "+"));
        }

        [Test]
        public void SumTest1()
        {
            Assert.AreEqual(6, new calc.vichisleniya().vichislenie(3, 3, "+"));
        }

        [Test]
        public void SumTest2()
        {
            Assert.AreEqual(0, new calc.vichisleniya().vichislenie(3, -3, "+"));
        }

        [Test]
        public void RaznTest()
        {
            Assert.AreEqual(5, new calc.vichisleniya().vichislenie(2, 3, "-"));
        }

        [Test]
        public void RaznTest1()
        {
            Assert.AreEqual(0, new calc.vichisleniya().vichislenie(3, 3, "-"));
        }

        [Test]
        public void RaznTest2()
        {
            Assert.AreEqual(6, new calc.vichisleniya().vichislenie(3, -3, "-"));
        }

        [Test]
        public void MultTest()
        {
            Assert.AreEqual(6, new calc.vichisleniya().vichislenie(2, 3, "*"));
        }

        [Test]
        public void MultTest1()
        {
            Assert.AreEqual(6, new calc.vichisleniya().vichislenie(3, 3, "*"));
        }

        [Test]
        public void MultTest2()
        {
            Assert.AreEqual(-9, new calc.vichisleniya().vichislenie(3, -3, "*"));
        }

        [Test]
        public void DivTest()
        {
            Assert.AreEqual(3, new calc.vichisleniya().vichislenie(9, 3, "/"));
        }

        [Test]
        public void DivTest1()
        {
            Assert.AreEqual(1, new calc.vichisleniya().vichislenie(3, 3, "/"));
        }

        [Test]
        public void DivTest2()
        {
            Assert.AreEqual(0, new calc.vichisleniya().vichislenie(3, -3, "/"));
        }

    }
}
