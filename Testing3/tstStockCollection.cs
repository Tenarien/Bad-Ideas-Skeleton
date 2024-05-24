using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            Assert.IsNotNull(AllBooks);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.BookId = 1;
            TestItem.Title = "TestBook";
            TestItem.Price = 1.00m;
            TestItem.Quantity = 100;
            TestItem.SupplierId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestList.Add(TestItem);
            AllBooks.StockList = TestList;
            Assert.AreEqual(AllBooks.StockList, TestList);
        }

        [TestMethod]
        public void ThisBookPropertyOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            clsStock TestBook = new clsStock();
            TestBook.Available = true;
            TestBook.BookId = 1;
            TestBook.Title = "TestBook";
            TestBook.Price = 1.00m;
            TestBook.Quantity = 100;
            TestBook.SupplierId = 1;
            TestBook.DateAdded = DateTime.Now;
            AllBooks.ThisBook = TestBook;
            Assert.AreEqual(AllBooks.ThisBook, TestBook);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestBook = new clsStock();
            TestBook.Available = true;
            TestBook.BookId = 1;
            TestBook.Title = "TestBook";
            TestBook.Price = 1.00m;
            TestBook.Quantity = 100;
            TestBook.SupplierId = 1;
            TestBook.DateAdded = DateTime.Now;
            TestList.Add(TestBook);
            AllBooks.StockList = TestList;
            Assert.AreEqual(AllBooks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            clsStock TestBook = new clsStock();
            Int32 PrimaryKey = 0;
            TestBook.Available = true;
            TestBook.BookId = 1;
            TestBook.Title = "TestBook";
            TestBook.Price = 1.00m;
            TestBook.Quantity = 100;
            TestBook.SupplierId = 1;
            TestBook.DateAdded = DateTime.Now;
            AllBooks.ThisBook = TestBook;
            PrimaryKey = AllBooks.Add();
            TestBook.BookId = PrimaryKey;
            AllBooks.ThisBook.Find(PrimaryKey);
            Assert.AreEqual(AllBooks.ThisBook, TestBook);
        }

        [TestMethod]
        public void UpdatemethodOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            clsStock TestBook = new clsStock();
            Int32 PrimaryKey = 0;

            TestBook.Available = true;
            TestBook.BookId = 1;
            TestBook.Title = "TestBook";
            TestBook.Price = 1.00m;
            TestBook.Quantity = 100;
            TestBook.SupplierId = 1;
            TestBook.DateAdded = DateTime.Now;

            AllBooks.ThisBook = TestBook;
            PrimaryKey = AllBooks.Add();
            TestBook.BookId = PrimaryKey;

            TestBook.Available = false;
            TestBook.BookId = 3;
            TestBook.Title = "TestBook2: Electric Boogaloo";
            TestBook.Price = 5.00m;
            TestBook.Quantity = 50;
            TestBook.SupplierId = 4;
            TestBook.DateAdded = DateTime.Now;

            AllBooks.ThisBook = TestBook;
            AllBooks.Update();
            AllBooks.ThisBook.Find(PrimaryKey);
            Assert.AreEqual (AllBooks.ThisBook, TestBook);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            clsStock TestBook = new clsStock();
            Int32 PrimaryKey = 0;

            TestBook.Available = true;
            TestBook.BookId = 1;
            TestBook.Title = "TestBook";
            TestBook.Price = 1.00m;
            TestBook.Quantity = 100;
            TestBook.SupplierId = 1;
            TestBook.DateAdded = DateTime.Now;

            AllBooks.ThisBook = TestBook;
            PrimaryKey = AllBooks.Add();
            TestBook.BookId = PrimaryKey;

            AllBooks.ThisBook.Find(PrimaryKey);
            AllBooks.Delete();
            Boolean Found = AllBooks.ThisBook.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            clsStockCollection AllBooks = new clsStockCollection();
            clsStockCollection FilteredBooks = new clsStockCollection();
            FilteredBooks.ReportByTitle("");
            Assert.AreEqual(AllBooks.Count, FilteredBooks.Count);
        }

        [TestMethod]
        public void ReportByTitleNotFound() 
        {
            clsStockCollection FilteredBooks = new clsStockCollection();
            FilteredBooks.ReportByTitle("abcxyz");
            Assert.AreEqual(0, FilteredBooks.Count);
        }

        [TestMethod]
        public void ReportByTitleTestDataFound()
        {
            clsStockCollection FilteredBooks = new clsStockCollection();
            Boolean OK = true;
            FilteredBooks.ReportByTitle("The Hobbit");
            if (FilteredBooks.Count == 2)
            {
                if (FilteredBooks.StockList[0].BookId != 2)
                {
                    OK = false;
                }
                if (FilteredBooks.StockList[1].BookId != 25)
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
