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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        Session["AnOrder"] = AnOrder; 
        Response.Redirect("OrderViewer.aspx");
    
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

        AnOrder.StaffId = Convert.ToInt32(txtStaffId.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

        AnOrder.OrderDate = Convert.ToDateTime(DateTime.Now);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

        AnOrder.TotalPrice = Convert.ToInt32(txtTotalPrice.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

        AnOrder.ShippingAddress = txtShippingAddress.Text;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

        AnOrder.ShippingStatus = chkShippingStatus.Checked;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId); 
        if (Found == true)
        {
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtStaffId.Text = AnOrder.StaffId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            chkShippingStatus.Checked = AnOrder.ShippingStatus;
            lblError.Text = ""; 

        }
        else
        {
            lblError.Text = "OrderId not found";

        }
    }
}