using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class InstanceOK()
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }
    }

    [TestMethod]
    public void SupplierId()
    {

        //create an instance of the class we want to increase
        clsSupplier AnSupplier = new clsSupplier();
        //create some test data to the property
        String TestData = "12";
        //assign the data to the property
        AnSupplier.Active = TestData;
        //test to see the value
        Assert.AreEqual(AnSupplier.Active,TestData);
    }
}



