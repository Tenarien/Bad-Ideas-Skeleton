using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayPayments();
        }
    }

    void DisplayPayments()
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        lstPaymentList.DataSource = Payments.PaymentList;
        lstPaymentList.DataValueField = "PaymentID";
        lstPaymentList.DataTextField = "PaymentMethod";
        lstPaymentList.DataTextField = "Amount";
        lstPaymentList.DataBind();
    }
}