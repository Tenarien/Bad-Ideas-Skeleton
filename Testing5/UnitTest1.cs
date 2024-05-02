using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsAddress AnAddess = new clsAddress();
            Assert.IsNotNull(AnAddess);
        }
    }
}

