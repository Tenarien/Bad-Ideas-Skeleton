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
        if(IsPostBack == false)
        {
            DisplaySuppliers();
        }
        clsSupplierUser AnUser = new clsSupplierUser();
        AnUser = (clsSupplierUser)Session["AnUser"];
        Response.Write("Logged in a:" + AnUser.UserName);
    }

    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;

        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        Int32 SupplierId;

        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SupplierDataEntry.aspx");


        }
        else
        {
            lblError.Text = "Select Supplier.";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;

        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplierId;

            Response.Redirect("SupplierConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a Supplier to Delete.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierName(txtSupplierNameFilter.Text);
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField= "SupplierId";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierName("");
        txtSupplierNameFilter.Text = ""; 
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void btnteammainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}