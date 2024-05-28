using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstPaymentUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPaymentUser AnUser = new clsPaymentUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsPaymentUser AnUser = new clsPaymentUser();
            Int32 TestData = 1;
            AnUser.UserId = TestData;
            Assert.AreEqual(AnUser.UserId, TestData);
        }


        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsPaymentUser AnUser = new clsPaymentUser();
            string TestData = "Syeda";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsPaymentUser AnUser = new clsPaymentUser();
            string TestData = "Password123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }



        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsPaymentUser AnUser = new clsPaymentUser();
            string TestData = "Payments Department";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }


        [TestMethod]

        public void FindUserMethodOK()
        {
            clsPaymentUser AnUser = new clsPaymentUser();
            Boolean Found = false;
            string UserName = "Syeda";
            string Password = "Password123";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }



        [TestMethod]

        public void TestUserNamePWFound()
        {
            clsPaymentUser AnUser = new clsPaymentUser();
            Boolean Found = false;
            Boolean Ok = true;
            string UserName = "Syeda";
            string Password = "Password123";

            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
