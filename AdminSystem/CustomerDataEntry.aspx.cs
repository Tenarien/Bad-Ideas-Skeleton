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


    protected void txtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerSurname_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerAccountCreationDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new istance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture customer ID
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //capture customer surname
        AnCustomer.CustomerSurname = txtCustomerSurname.Text;
        //capture customer first name
        AnCustomer.CustomerFirstName = txtCustomerFirstName.Text;
        //capture customer email
        AnCustomer.CustomerEmail = txtCustomerEmail.Text;
        //capture customer address
        AnCustomer.CustomerAddress = txtCustomerAddress.Text;
        //capture account creation date
        AnCustomer.AccountCreationDate = Convert.ToDateTime(DateTime.Now);
        //capture Active check box
        AnCustomer.AccountVerification = chkAccountVerification.Checked;
        //store the customer in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}