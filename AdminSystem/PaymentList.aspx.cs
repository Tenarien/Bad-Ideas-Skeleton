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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PaymentID"] = -1;
        Response.Redirect("PaymentDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 PaymentID;
        if (lstPaymentList.SelectedIndex != -1)
        {
            PaymentID = Convert.ToInt32(lstPaymentList.SelectedValue);
            Session["PaymentID"] = PaymentID;
            Response.Redirect("PaymentDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select an Amount to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 PaymentID;
        if (lstPaymentList.SelectedIndex != -1)
        {
            PaymentID = Convert.ToInt32(lstPaymentList.SelectedValue);
            Session["PaymentID"] = PaymentID;
            Response.Redirect("PaymentConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Select Entry to Delete the Payment.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsPaymentCollection APayment = new clsPaymentCollection();
        APayment.ReportByPaymentMethod(txtPaymentMethod.Text);
        lstPaymentList.DataSource = APayment.PaymentList;
        lstPaymentList.DataValueField = "PaymentID";
        lstPaymentList.DataTextField = "Amount";
        lstPaymentList.DataBind();
    }

    protected void lblClearFilter_Click(object sender, EventArgs e)
    {
        clsPaymentCollection APayment = new clsPaymentCollection();
        APayment.ReportByPaymentMethod("");
        txtPaymentMethod.Text = "";
        lstPaymentList.DataSource = APayment.PaymentList;
        lstPaymentList.DataValueField = "PaymentID";
        lstPaymentList.DataTextField = "Amount";
        lstPaymentList.DataBind();
    }
}