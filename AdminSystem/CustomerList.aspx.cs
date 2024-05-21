using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }


    void DisplayCustomers()
    {
        //create an instance of the class we want to create
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of addresses in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the datafield to display
        lstCustomerList.DataTextField = "CustomerFirstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the promary key value
        Int32 CustomerId;
        //if a record has een selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get primary key value
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store data in session object
            Session[CustomerId] = CustomerId;
            //redirect to edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}