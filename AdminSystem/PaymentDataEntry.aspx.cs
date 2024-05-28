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
        clsPayment APayment = new clsPayment();


        string PaymentMethod = txtPaymentMethod.Text;
        string Amount = txtAmount.Text;
        string Currency = txtCurrency.Text;
        string PaymentDate = txtPaymentDate.Text;
        Boolean StatusCleared = Convert.ToBoolean(chkStatusCleared.Checked);


        string Error = "";
        Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
        if (Error == "")
        {
            APayment.PaymentMethod = PaymentMethod;
            APayment.Amount = Convert.ToDouble(Amount);
            APayment.Currency = Currency;
            APayment.PaymentDate = Convert.ToDateTime(PaymentDate);
            APayment.StatusCleared = Convert.ToBoolean(StatusCleared);

            /*clsPaymentCollection PaymentList = new clsPaymentCollection();

            if (PaymentID == -1)
            {
                PaymentList.ThisPayment = APayment;
                PaymentList.Add();
            }
            else
            {
                PaymentList.ThisPayment.Find(PaymentID);
                PaymentList.ThisPayment = APayment;
                PaymentList.Update();
            }
            */
            Session["APayment"] = APayment;
            Response.Redirect("PaymentViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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