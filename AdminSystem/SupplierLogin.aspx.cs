﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class SupplierLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsSupplierUser AnUser = new clsSupplierUser();

        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnUser.FindUser(UserName, Password);

        Session["AnUser"] = AnUser;

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter User Name ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter Password";
        }

        else if (Found == true)
        {
            Response.Redirect("SupplierList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login Details are incorrect";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}