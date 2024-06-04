using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 PaymentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
        if (IsPostBack == false)
        {
            if (PaymentID != -1)
            {
                DisplayPayment();
            }
            clsPaymentUser AnUser = new clsPaymentUser();
            AnUser = (clsPaymentUser)Session["AnUser"];
            Response.Write("Logged in as : " + AnUser.UserName);
        }
    }

    void DisplayPayment()
    {
        clsPaymentCollection PaymentsAll = new clsPaymentCollection();
        PaymentsAll.ThisPayment.Find(PaymentID);

        txtPaymentID.Text = PaymentsAll.ThisPayment.PaymentID.ToString();
        txtPaymentMethod.Text = PaymentsAll.ThisPayment.PaymentMethod.ToString();
        txtCurrency.Text = PaymentsAll.ThisPayment.Currency.ToString();
        txtAmount.Text = PaymentsAll.ThisPayment.Amount.ToString();
        txtPaymentDate.Text = PaymentsAll.ThisPayment.PaymentDate.ToString();
        chkStatusCleared.Checked = PaymentsAll.ThisPayment.StatusCleared;
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
            APayment.PaymentID = PaymentID; 
            APayment.PaymentMethod = PaymentMethod;
            APayment.Amount = Convert.ToDouble(Amount);
            APayment.Currency = Currency;
            APayment.PaymentDate = Convert.ToDateTime(PaymentDate);
            APayment.StatusCleared = Convert.ToBoolean(StatusCleared);

            clsPaymentCollection PaymentList = new clsPaymentCollection();

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
            Response.Redirect("PaymentList.aspx");
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

    protected void btnTeamMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}