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


        //create new instance
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from session object
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display username
        Response.Write("Logged in as: " + AnUser.UserName);

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
            Session["CustomerId"] = CustomerId;
            //redirect to edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the promary key value
        Int32 CustomerId;
        //if a record has een selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get primary key value
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store data in session object
            Session["CustomerId"] = CustomerId;
            //redirect to delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error message
            lblError.Text = "Please delect a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrieve the value of email from presentation layer
        AnCustomer.ReportByEmail(txtFilter.Text);
        //set the datasource
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set name of primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set name of field to display
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //set an empty string
        AnCustomer.ReportByEmail("");
        //clear any existing filter
        txtFilter.Text = "";
        //set the data source to the lst of customers in collections
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set name of field to display
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to list
        lstCustomerList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}