using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestProject1
    {
        [TestMethod]
        public void TestMethod1()
        {
            acount acc = new acount(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(acount));
            Assert.AreEqual(200000, acc.Balance());

        }
    }
}
