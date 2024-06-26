﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store primary key of the record to be deleted
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of customers to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of customer collection class
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to delete
        Customers.ThisCustomer.Find(CustomerId);
        //delete the record
        Customers.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}