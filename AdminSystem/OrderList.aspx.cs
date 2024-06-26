﻿using System;
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

        //Create a new instance of clsOrder
        clsOrderUser AnUser = new clsOrderUser();
        //get data from the session object 
        AnUser = (clsOrderUser)Session["AnUser"];
        //display the username 
        Response.Write("Logged in as: " + AnUser.UserName);
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
        else   //if no record has been selected
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

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to craete
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve the value of shipping address from the presentation layer 
        AnOrder.ReportByShippingAddress(txtEnterShippimgAddress.Text);
        //set the data source to the list of orders in the collectiion
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display 
        lstOrderList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrderList.DataBind();    
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to craete
        clsOrderCollection AnOrder = new clsOrderCollection();
        //set an empty string
        AnOrder.ReportByShippingAddress("");
        //clear any existing filter to tidy up the interface 
        txtEnterShippimgAddress.Text = "";
        //set the data source to the list of orders in te collection 
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrderList.DataBind();

    }
}