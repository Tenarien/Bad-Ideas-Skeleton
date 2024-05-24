using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockUser aUser = new clsStockUser();
            Assert.IsNotNull(aUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStockUser aUser = new clsStockUser();
            Int32 TestData = 1;
            aUser.UserID = TestData;
            Assert.AreEqual(aUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser aUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "Scott";
            //assign the data to the property
            aUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser aUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            aUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser aUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "Stock Management";
            //assign the data to the property
            aUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStockUser aUser = new clsStockUser();
            Boolean Found = false;
            string UserName = "Scott";
            string Password = "Wordpass123";
            Found = aUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsStockUser aUser = new clsStockUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Scott";
            string Password = "Wordpass123";
            Found = aUser.FindUser(UserName, Password);
            if(aUser.UserName != UserName && aUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
