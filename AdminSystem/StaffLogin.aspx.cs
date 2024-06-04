using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve the session object
        clsStaffUser AnUser = (clsStaffUser)Session["AnUser"];

        // Check if the user is logged in
        if (AnUser != null)
        {
            Response.Redirect("StaffList.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaffUser AnUser = new clsStaffUser();

        string UserName = txtUserName.Text;
        string password = txtPassword.Text;

        Boolean Found = false;

        UserName = Convert.ToString(txtUserName.Text);
        password = Convert.ToString(txtPassword.Text);

        Found = AnUser.FindUser(UserName, password);

        Session["AnUser"] = AnUser;

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a Username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password ";
        }
        else if (Found == true)
        {
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}