using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //test to see if the result is true
            Assert.IsNotNull(aStaff);
        }


        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable and assign it to the property
            int TestData = 1;
            aStaff.StaffId = TestData;
            //test to see if the result is true
            Assert.AreEqual(aStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable and assign it to the property
            string TestData = "John";
            aStaff.StaffName = TestData;
            //test to see if the result is true
            Assert.AreEqual(aStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable and assign it to the property
            string TestData = "13 London Road";
            aStaff.StaffAddress = TestData;
            //test to see if the result is true
            Assert.AreEqual(aStaff.StaffAddress, TestData);
        }

        [TestMethod]
        public void StaffDatePropertyOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable and assign it to the property
            DateTime TestData = DateTime.Now.Date;
            aStaff.StaffDate = TestData;
            //test to see if the result is true
            Assert.AreEqual(aStaff.StaffDate, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable and assign it to the property
            string TestData = "Customer Help";
            aStaff.StaffRole = TestData;
            //test to see if the result is true
            Assert.AreEqual(aStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffPrivilagePropertyOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable and assign it to the property
            Boolean TestData = true;
            aStaff.StaffPrivilage = TestData;
            //test to see if the result is true
            Assert.AreEqual(aStaff.StaffPrivilage, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable and assign it to the property
            Boolean Found = false;
            Int32 StaffId = 1;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable
            Boolean Found = false;
            Boolean OK = true;

            //declare a variable and assign it to the property
            Int32 StaffId = 1;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            if (aStaff.StaffId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable
            Boolean Found = false;
            Boolean OK = true;

            //declare a variable and assign it to the property
            Int32 StaffId = 1;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            if (aStaff.StaffName != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable
            Boolean Found = false;
            Boolean OK = true;

            //declare a variable and assign it to the property
            Int32 StaffId = 1;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            if (aStaff.StaffAddress != "123 Test Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDateFound()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable
            Boolean Found = false;
            Boolean OK = true;

            //declare a variable and assign it to the property
            Int32 StaffId = 1;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            if (aStaff.StaffDate != Convert.ToDateTime("15/06/2017"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable
            Boolean Found = false;
            Boolean OK = true;

            //declare a variable and assign it to the property
            Int32 StaffId = 1;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            if (aStaff.StaffRole != "Staff")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPrivilageFound()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();
            //declare a variable
            Boolean Found = false;
            Boolean OK = true;

            //declare a variable and assign it to the property
            Int32 StaffId = 1;
            //invoke the method
            Found = aStaff.Find(StaffId);
            //test to see if the result is true
            if (aStaff.StaffPrivilage != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
