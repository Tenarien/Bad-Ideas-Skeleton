﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create new instance of staff class
        clsStaff aStaff = new clsStaff();
        //Get the data from the session object
        aStaff = (clsStaff)Session["aStaff"];
        //Display staff information for this entry
        Response.Write(aStaff);
    }
}