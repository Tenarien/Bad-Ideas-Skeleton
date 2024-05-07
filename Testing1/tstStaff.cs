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
            clsStaff aStaff = new clsStaff();

            Assert.IsNotNull(aStaff);
        }


        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            int TestData = 1;
            aStaff.StaffId = TestData;

            Assert.AreEqual(aStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "John";
            aStaff.StaffName = TestData;

            Assert.AreEqual(aStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "13 London Road";
            aStaff.StaffAddress = TestData;

            Assert.AreEqual(aStaff.StaffAddress, TestData);
        }

        [TestMethod]
        public void StaffDatePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            aStaff.StaffDate = TestData;

            Assert.AreEqual(aStaff.StaffDate, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "Customer Help";
            aStaff.StaffRole = TestData;

            Assert.AreEqual(aStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffPrivilagePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            bool TestData = true;
            aStaff.StaffPrivilage = TestData;

            Assert.AreEqual(aStaff.StaffPrivilage, TestData);
        }
    }
}
