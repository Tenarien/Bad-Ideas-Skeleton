using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 PaymentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        clsPaymentCollection AllPayments = new clsPaymentCollection();
        AllPayments.ThisPayment.Find(PaymentID);
        AllPayments.Delete();
        Response.Redirect("PaymentList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentList.aspx");
    }
}