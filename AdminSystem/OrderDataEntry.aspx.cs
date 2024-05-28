using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; 

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope 
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed 
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if(IsPostBack == false)
        {
            //if this is not a new record 
            if (OrderId != -1)
            {
                //display the current data for the record 
                DisplayOrder();
            }
        }

    }

    void DisplayOrder()
    {
        //create an instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update 
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for the record 
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtStaffId.Text = OrderBook.ThisOrder.StaffId.ToString();
        txtShippingAddress.Text = OrderBook.ThisOrder.ShippingAddress;
        chkShippingStatus.Checked = OrderBook.ThisOrder.ShippingStatus;
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtTotalPrice.Text = OrderBook.ThisOrder.TotalPrice.ToString(); 

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
            AnOrder.OrderId = OrderId;
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.StaffId = Convert.ToInt32(StaffId);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalPrice = Convert.ToInt32(TotalPrice);
            AnOrder.ShippingAddress = ShippingAddress;
            AnOrder.ShippingStatus = chkShippingStatus.Checked;
            //create an instance of the order collection 
            clsOrderCollection OrderList = new clsOrderCollection();
            
            //if this is a new record i.e OrderId = -1 then add the data
            if(OrderId == -1)
            {
                //set the ThisOrder property 
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update 
            else
            {
                //find the record to update 
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder properly
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
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
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
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

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}