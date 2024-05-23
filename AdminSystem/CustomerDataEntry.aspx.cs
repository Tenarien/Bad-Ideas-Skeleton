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
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new recod
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }


    protected void txtCustomerId_Text(object sender, EventArgs e)
    {

    }

    protected void txtCustomerFirstName_Text(object sender, EventArgs e)
    {

    }

    protected void txtCustomerSurname_Text(object sender, EventArgs e)
    {

    }

    protected void txtCustomerEmail_Text(object sender, EventArgs e)
    {

    }

    protected void txtCustomerAddress_Text(object sender, EventArgs e)
    {

    }

    protected void txtCustomerAccountCreationDate_Text(object sender, EventArgs e)
    {

    }

    protected void chkAccountVerification_Checked(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new istance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture customer first name
        string CustomerFirstName = txtCustomerFirstName.Text;
        //capture customer surname
        string CustomerSurname = txtCustomerSurname.Text;
        //capture customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture customer address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture account creation date
        string AccountCreationDate = txtCustomerAccountCreationDate.Text;
        //capture verification check box
        string AccountVerification = chkAccountVerification.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
        if (Error == "")
        {
            //capture customer id
            AnCustomer.CustomerId = CustomerId;
            //capture customer fist name
            AnCustomer.CustomerFirstName = CustomerFirstName;
            //capture customer surname
            AnCustomer.CustomerSurname = CustomerSurname;
            //capture custoemr email
            AnCustomer.CustomerEmail = CustomerEmail;
            //capture customer address
            AnCustomer.CustomerAddress = CustomerAddress;
            //capture account creation date
            AnCustomer.AccountCreationDate = Convert.ToDateTime(AccountCreationDate);
            //capture account verification
            AnCustomer.AccountVerification = chkAccountVerification.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record, then add data
            if (CustomerId == -1)
            {
                //set the thiscustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }

            //otherwise it must be an update
            else
            {
                //find the record to updatw
                CustomerList.ThisCustomer.Find(CustomerId);
                //set te thiscustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }

            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new istance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);  
        //find the record
        Found = AnCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerFirstName.Text = AnCustomer.CustomerFirstName;
            txtCustomerSurname.Text = AnCustomer.CustomerSurname;
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtCustomerAddress.Text = AnCustomer.CustomerAddress;
            txtCustomerAccountCreationDate.Text = AnCustomer.AccountCreationDate.ToString();
            chkAccountVerification.Checked = AnCustomer.AccountVerification;
        }
    }


    void DisplayCustomer()
    {
        //create an instance of the class we want to create
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(CustomerId);
        //display the data for the record
        txtCustomerId.Text = Customer.ThisCustomer.CustomerId.ToString();
        txtCustomerFirstName.Text = Customer.ThisCustomer.CustomerFirstName.ToString();
        txtCustomerSurname.Text = Customer.ThisCustomer.CustomerSurname.ToString();
        txtCustomerEmail.Text = Customer.ThisCustomer.CustomerEmail.ToString();
        txtCustomerAddress.Text = Customer.ThisCustomer.CustomerAddress.ToString();
        txtCustomerAccountCreationDate.Text = Customer.ThisCustomer.AccountCreationDate.ToString();
        chkAccountVerification.Checked = Customer.ThisCustomer.AccountVerification;

    }



}