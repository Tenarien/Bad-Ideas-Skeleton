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

protected void btnok_Click(object sender, EventArgs e)
    {
        // create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        // capture the supplierName


        AnSupplier.SupplierName = txtSupplierName.Text;
        //store the ADDRESS IN THE SESSION OBJECT
        Session["AnSupplier"] = AnSupplier;
        //navigate to view page
        Response.Redirect("SupplierViewer.aspx");
    }
}
