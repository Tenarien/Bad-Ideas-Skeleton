using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayOrder();

        }
    }
    void DisplayOrder()
    {
        // create an instance of the class we want to craete
        clsOrderCollection Order = new clsOrderCollection();
        //set the data source to list of addresses in the collection
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderNo";
        //set the dtat field to display
        lstOrderList.DataTextField = "Shipping Address";
        //blind the data to the list
        lstOrderList.DataBind();
    }
}