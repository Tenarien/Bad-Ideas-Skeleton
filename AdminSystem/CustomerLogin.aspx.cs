using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //craete an instamce
        clsCustomerUser AnUser = new clsCustomerUser(); 
        //create the variables to store usernam and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create variable tostore result of operaion
        Boolean Found = false;
        //get username entered by user
        UserName = Convert.ToString(txtUserName.Text);
        //get password entered by user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //add a sessio to capture username
        Session["AnUser"] = AnUser;
        //if username/password is emty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username ";
        }

        else if (txtPassword.Text == "") 
        {
            //record the error
            lblError.Text = "Enter a password ";
        }

        //if found
        else if (Found == true)
        {
            //redirect to list page
            Response.Redirect("CustomerList.aspx");
        }

        else if (Found == false)
        {
            //record error
            lblError.Text = "Login details are incorrect. Please try again.";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}