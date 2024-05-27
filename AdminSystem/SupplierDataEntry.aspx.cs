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
        String SupplierName = txtSupplierName.Text;
        String SupplierAddress = TxtSupplierAddress.Text;
        String ContractDate = txtContractDate.Text;
        String AvailableSupplier = chkAvailableSupplier.Text;
        String Error = "";
        Error = AnSupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);

        if(Error == "")
        {
            AnSupplier.SupplierName = SupplierName;
            AnSupplier.ContractDate = Convert.ToDateTime(ContractDate);
            AnSupplier.AvailableSupplier = chkAvailableSupplier.Checked;
            AnSupplier.SupplierAddress = SupplierAddress;

            Session["AnSupplier"] = AnSupplier;
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }




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
