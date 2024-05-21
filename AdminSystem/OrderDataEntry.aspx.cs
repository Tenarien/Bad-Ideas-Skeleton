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
        string CustomerId = txtCustomerId.Text;
        string StaffId = txtStaffId.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalPrice = txtTotalPrice.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string ShippingStatus = chkShippingStatus.Text;
        string Error = "";
        Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
        if (Error == "")
        {
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.StaffId = Convert.ToInt32(StaffId);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalPrice = Convert.ToInt32(TotalPrice);
            AnOrder.ShippingAddress = txtShippingAddress.Text;
            AnOrder.ShippingStatus = chkShippingStatus.Checked;
            //create an instance of the order collection 
            clsOrderCollection OrderList = new clsOrderCollection();    
            //set theThisOrder property 
            OrderList.ThisOrder = AnOrder;
            //add the new record 
            OrderList.Add();
            //redirect back to the list page 
            Response.Redirect("OrderList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error; 
        }


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