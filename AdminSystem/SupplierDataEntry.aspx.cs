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
        clsSupplier AnSupplier = new clsSupplier();
        //capture all input data
        Session["AnSupplier"] = AnSupplier;
        AnSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        AnSupplier.SupplierName = txtSupplierName.Text;
        AnSupplier.ContractDate = Convert.ToDateTime(DateTime.Now);
        AnSupplier.AvailableSupplier = chkAvailableSupplier.Checked;
        AnSupplier.SupplierAddress = TxtSupplierAddress.Text;

        Response.Redirect("SupplierViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();

        Int32 SupplierId;
        Boolean Found = false;
        SupplierId = Convert.ToInt32(txtSupplierId.Text);

        Found = ASupplier.Find(SupplierId);

        if (Found == true)
        {
            txtSupplierName.Text = ASupplier.SupplierName;
            TxtSupplierAddress.Text = ASupplier.SupplierAddress;
            txtContractDate.Text = ASupplier.ContractDate.ToString();
            chkAvailableSupplier.Checked = ASupplier.AvailableSupplier;
        }
    }
}
