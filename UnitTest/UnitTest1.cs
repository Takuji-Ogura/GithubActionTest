using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var form = new GithubActionTest.Form1();
            var ret = form.Sum(2, 3);
            Assert.AreEqual(6, ret);
        }
    }
}
