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
        aBook.Price = Convert.ToInt64(txtPrice.Text);
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
}