using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();

            TestItem.StaffId = 1;
            TestItem.StaffName = "John Doe";
            TestItem.StaffAddress = "12 Test Street";
            TestItem.StaffDate = DateTime.Now;
            TestItem.StaffPrivilage = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffId = 1;
            TestStaff.StaffName = "John Doe";
            TestStaff.StaffAddress = "12 Test Street";
            TestStaff.StaffDate = DateTime.Now;
            TestStaff.StaffPrivilage = true;

            AllStaff.ThisStaff = TestStaff;

            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();

            TestItem.StaffId = 1;
            TestItem.StaffName = "John Doe";
            TestItem.StaffAddress = "12 Test Street";
            TestItem.StaffDate = DateTime.Now;
            TestItem.StaffPrivilage = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }
}
