using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestQuadro
{
    [TestClass]
    public class QuadroTest
    {
        [TestMethod]
        public void dis()
        {
            double a = 5;
            double b = 3;
            double c = 7;
            double expected = -131;
            Quadro q = new Quadro(a, b, c);
            double actual = q.dis();
            Assert.AreEqual(expected, actual);
        }
    }
}
