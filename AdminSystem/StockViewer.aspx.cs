using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clasStock
        clsStock aBook = new clsStock();
        //get the data from the session object
        aBook = (clsStock)Session["aBook"];
        //display the title for this entry
        Response.Write(aBook.BookId);
        Response.Write(aBook.Title);
        Response.Write(aBook.DateAdded);
        Response.Write(aBook.Price);
        Response.Write(aBook.Quantity);
        Response.Write(aBook.SupplierId);
        Response.Write(aBook.Available);
    }
}