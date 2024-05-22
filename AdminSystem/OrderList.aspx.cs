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
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "ShippingAddress";
        //blind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into th session objct to indicate this is a new record 
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of th erecord to be edited 
        Int32 OrderId;
        //if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object 
            Session["OrderId"] = OrderId;
            //redirect to the edit page 
            Response.Redirect("OrderDataEntry.aspx");
        }
        else   //if no record has ben selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of th erecord to be edited 
        Int32 OrderId;
        //if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object 
            Session["OrderId"] = OrderId;
            //store to the delete page 
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected 
        {
            //display an error message 
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}