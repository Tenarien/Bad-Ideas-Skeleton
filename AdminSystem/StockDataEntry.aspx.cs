using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStock
        clsStock aBook = new clsStock();
        //Capture the title
        aBook.Title = txtTitle.Text;
        //Capture the book id
        aBook.BookId = Convert.ToInt32(txtBookId.Text);
        //Capture the date added
        aBook.DateAdded = Convert.ToDateTime(DateTime.Now);
        //Capture the price
        aBook.Price = Convert.ToDecimal(txtPrice.Text);
        //Capture the quantity
        aBook.Quantity = Convert.ToInt32(txtQuantity.Text);
        //Capture the supplier id
        aBook.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //Capture the availability
        aBook.Available = chkAvailable.Checked;
        //Store the book in the session object
        Session["aBook"] = aBook;
        //Navigate to the view page
        Response.Redirect("StockViewer.aspx");
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
}