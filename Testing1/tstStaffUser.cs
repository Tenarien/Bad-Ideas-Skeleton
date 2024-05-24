using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser AnUser = new clsStaffUser();

            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();

            Int32 TestData = 1;

            AnUser.UserID = TestData;

            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();

            string TestData = "John";

            AnUser.UserName = TestData;

            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();

            string TestData = "password123";

            AnUser.Password = TestData;

            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();

            string TestData = "Address Book";

            AnUser.Department = TestData;

            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStaffUser AnUser = new clsStaffUser();

            Boolean Found = false;
            string UserName = "Kris";
            string Password = "Pass123";

            Found = AnUser.FindUser(UserName, Password);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNameSFFound()
        {
            clsStaffUser AnUser = new clsStaffUser();

            Boolean Found = false;
            Boolean OK = true;

            string Username = "Kris";
            string Password = "Pass123";

            Found = AnUser.FindUser(Username, Password);

            if (AnUser.UserName != Username && AnUser.Password != Password) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
