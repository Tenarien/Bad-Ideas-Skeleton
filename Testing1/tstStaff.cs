using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        string StaffId = "1";
        string StaffName = "John Doe";
        string StaffAddress = "123 Test Street";
        string StaffDate = DateTime.Now.ToShortDateString();
        string StaffRole = "Staff";
        

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of class
            clsStaff aStaff = new clsStaff();
            //variable to store errors
            String Error = "";
            //invoke the method
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "a";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "aa";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(49, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "a";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "aa";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(49, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 day
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateInvalidData()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffDate = "this is not a date!";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "a";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "aa";
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(49, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(50, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(51, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(25, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(500, 'a');
            Error = aStaff.Valid(StaffId, StaffName, StaffAddress, StaffDate, StaffRole);
            Assert.AreNotEqual(Error, "");
        }
        
    }
}
