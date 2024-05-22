using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted 
    Int32 OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object 
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    
    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to craete
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to delete 
        Order.ThisOrder.Find(OrderId);
        //delete the record 
        Order.Delete();
        //reidrect back to main page 
        Response.Redirect("OrderList.aspx");
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        //redirect back to main page 
        Response.Redirect("OrderList.aspx");
    }
}