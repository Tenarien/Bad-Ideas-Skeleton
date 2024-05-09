using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderId);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.StaffId);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.CustomerId);
        
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderDate);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.TotalPrice);

        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.ShippingAddress);
       
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.ShippingStatus);


    }

   
}