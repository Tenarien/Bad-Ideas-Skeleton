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



    protected void btnOK_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsPayment APayment = new clsPayment();
        Int32 PaymentID;
        Boolean Found = false;
        PaymentID = Convert.ToInt32(txtPaymentID.Text);
        Found = APayment.Find(PaymentID);
        if (Found == true)
        {
            txtPaymentDate.Text = APayment.PaymentDate.ToString();
            txtPaymentMethod.Text = APayment.PaymentMethod;
            txtAmount.Text = APayment.Amount.ToString();
            txtCurrency.Text = APayment.Currency;
            chkStatusCleared.Checked = APayment.StatusCleared;
        }
    }
}