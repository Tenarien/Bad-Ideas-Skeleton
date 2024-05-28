using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the order user class
        clsOrderUser AnUser = new clsOrderUser();  
        //create the variable to store the username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create the variables to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user 
        UserName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user 
        Password = Convert.ToString(txtPassword.Text);
        //find the record 
        Found = AnUser.FindUser(UserName, Password);
        //add a session to capture the username
        Session["AnUser"] = AnUser;
        //if username and/or password is empty
        if (txtUserName.Text == "")
        {
            //record the error 
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a password";
        }
        //if found 
        else if (Found == true)
        {
            //redirect to the lsit page 
            Response.Redirect("OrderList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. please try agian";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");

    }
}