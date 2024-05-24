using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstCustomerUser
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //test to see it exists
            Assert.IsNotNull(AnUser);
        }


        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to property
            Int32 TestData = 1;
            //assign data to property
            AnUser.UserID = TestData;
            //test to see if 2 values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }


        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to property
            string TestData = "Amanda";
            //assign data to property
            AnUser.UserName = TestData;
            //test to see if 2 values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to property
            string TestData = "Password123";
            //assign data to property
            AnUser.Password = TestData;
            //test to see if 2 values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }


        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to property
            string TestData = "Customer Management";
            //assign data to property
            AnUser.Department = TestData;
            //test to see if 2 values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }


        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //boolean variable to store results of validation
            Boolean Found = false;
            //create some test data
            string UserName = "Amanda";
            string Password = "Password123";
            //invoke method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestUserNameCMFound()
        {
            //create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //boolean variable to store results of validation
            Boolean Found = false;
            //boolean to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            string UserName = "Amanda";
            string Password = "Password123";
            //invoke method
            Found = AnUser.FindUser(UserName, Password);
            //check user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see result is ok
            Assert.IsTrue(OK);
        }


    }
}
