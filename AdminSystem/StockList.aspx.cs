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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 BookId;

        if(lstStockList.SelectedIndex != -1)
        {
            BookId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["BookId"] = BookId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 BookId;
        if(lstStockList.SelectedIndex != -1)
        {
            BookId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["BookId"] = BookId;
            Response.Redirect("StockConfirmdelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection aBook = new clsStockCollection();
        aBook.ReportByTitle(txtFilter.Text);
        lstStockList.DataSource = aBook.StockList;
        lstStockList.DataValueField = "BookId";
        lstStockList.DataTextField = "Title";
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection aBook = new clsStockCollection();
        aBook.ReportByTitle("");
        txtFilter.Text = "";
        lstStockList.DataSource = aBook.StockList;
        lstStockList.DataValueField = "BookId";
        lstStockList.DataTextField = "Title";
        lstStockList.DataBind();
    }
}