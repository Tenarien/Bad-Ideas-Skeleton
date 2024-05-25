using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 BookId;

    protected void Page_Load(object sender, EventArgs e)
    {
        BookId = Convert.ToInt32(Session["BookId"]);
        if(IsPostBack == false)
        {
            if(BookId != -1)
            {
                DisplayBook();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStock
        clsStock aBook = new clsStock();
        //Capture the title
        string Title = txtTitle.Text;
        //Capture the date added
        string DateAdded = txtDateAdded.Text;
        //Capture the price
        string Price = txtPrice.Text;
        //Capture the quantity
        string Quantity = txtQuantity.Text;
        //Capture the supplier id
        string SupplierId = txtSupplierId.Text;
        //Capture the availability
        string Available = chkAvailable.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
        if(Error == "")
        {
            aBook.BookId = BookId;
            //Capture the title
            aBook.Title = txtTitle.Text;
            //Capture the date added
            aBook.DateAdded = Convert.ToDateTime(DateAdded);
            //Capture the price
            aBook.Price = Convert.ToDecimal(Price);
            //Capture the quantity
            aBook.Quantity = Convert.ToInt32(Quantity);
            //Capture the supplier id
            aBook.SupplierId = Convert.ToInt32(SupplierId);
            //Capture available
            aBook.Available = chkAvailable.Checked;
            //
            clsStockCollection StockList = new clsStockCollection();

            if(BookId == -1)
            {
                StockList.ThisBook = aBook;
                //add the new record
                StockList.Add();
            }
            else
            {
                StockList.ThisBook.Find(BookId);
                StockList.ThisBook = aBook;
                StockList.Update();
            }
            //Navigate to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock aBook = new clsStock();
        Int32 BookId;
        Boolean Found = false;
        BookId = Convert.ToInt32(txtBookId.Text);
        Found = aBook.Find(BookId);
        if(Found == true)
        {
            txtDateAdded.Text = aBook.DateAdded.ToString();
            txtTitle.Text = aBook.Title;
            txtPrice.Text = aBook.Price.ToString();
            txtQuantity.Text = aBook.Quantity.ToString();
            txtSupplierId.Text = aBook.SupplierId.ToString();
            chkAvailable.Checked = aBook.Available;

        }
    }

    void DisplayBook()
    {
        clsStockCollection AllBooks = new clsStockCollection();
        AllBooks.ThisBook.Find(BookId);
        txtDateAdded.Text = AllBooks.ThisBook.DateAdded.ToString();
        txtTitle.Text = AllBooks.ThisBook.Title;
        txtPrice.Text = AllBooks.ThisBook.Price.ToString();
        txtQuantity.Text = AllBooks.ThisBook.Quantity.ToString();
        txtSupplierId.Text = AllBooks.ThisBook.SupplierId.ToString();
        chkAvailable.Checked = AllBooks.ThisBook.Available;
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}