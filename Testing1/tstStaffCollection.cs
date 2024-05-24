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
            TestItem.StaffRole = "Staff";

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffId = 1;
            TestItem.StaffName = "John Doe";
            TestItem.StaffAddress = "12 Test Street";
            TestItem.StaffDate = DateTime.Now;
            TestItem.StaffPrivilage = true;
            TestItem.StaffRole = "Staff";

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();

            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod] 
        public void UpdateMethodOK() 
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffName = "John Doe";
            TestItem.StaffAddress = "12 Test Street";
            TestItem.StaffDate = DateTime.Now;
            TestItem.StaffPrivilage = true;
            TestItem.StaffRole = "Staff";

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();

            TestItem.StaffId = PrimaryKey;

            TestItem.StaffName = "Johnny Moe";
            TestItem.StaffAddress = "33 Tested Street";
            TestItem.StaffDate = DateTime.Now;
            TestItem.StaffPrivilage = false;
            TestItem.StaffRole = "NotStaff";

            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            
            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffId = 1;
            TestItem.StaffName = "John Doe";
            TestItem.StaffAddress = "12 Test Street";
            TestItem.StaffDate = DateTime.Now;
            TestItem.StaffPrivilage = true;
            TestItem.StaffRole = "Staff";

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();

            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);

            AllStaff.Delete();

            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            FilteredStaff.ReportByName("");

            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            FilteredStaff.ReportByName("xxxx");

            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;

            FilteredStaff.ReportByName("Maria DB");
            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffId != 7)
                {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].StaffId != 8)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
