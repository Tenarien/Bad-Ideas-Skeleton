using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Assert.IsNotNull(AnUser);
        }


        /************************* Property OK Tests ************************/

        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Int32 TestData = 1;
            AnUser.UserId = TestData;
            Assert.AreEqual(AnUser.UserId, TestData);
        }


        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Shahzaib Faryad";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "1111";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }



        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Suppliers Department";

            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }


        [TestMethod]

        public void FindUserMethodOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            Boolean Found = false;

            string UserName = "Shahzaib";
            string Password = "1111";

            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }



        [TestMethod]

        public void TestUserNamePWFound()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            Boolean Found = false;
            Boolean Ok = true;

            string UserName = "Shahzaib";
            string Password = "1111";

            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
