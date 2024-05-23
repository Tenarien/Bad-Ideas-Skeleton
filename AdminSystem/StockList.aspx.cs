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
        if (IsPostBack == false)
        {
            DisplayBooks();
        }
    }

    void DisplayBooks()
    {
        clsStockCollection Books = new clsStockCollection();
        lstStockList.DataSource = Books.StockList;
        lstStockList.DataValueField = "BookId";
        lstStockList.DataTextField = "Title";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["BookId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }
}