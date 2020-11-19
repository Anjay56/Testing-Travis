using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing_Travis_CI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form1 = new Form1();

            Assert.AreEqual(3, form1.getX());
        }

        [TestMethod]
        public void TestY()
        {
            Form1 form = new Form1();

            Assert.AreEqual(4, form.getY());
        }
    }
}
