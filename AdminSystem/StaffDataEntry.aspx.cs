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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();

        Session["aStaff"] = aStaff;

        //Capture all input data
        aStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        aStaff.StaffName = txtStaffName.Text;
        aStaff.StaffAddress = txtStaffAddress.Text;
        aStaff.StaffDate = Convert.ToDateTime(txtStaffDate.Text);
        aStaff.StaffRole = txtStaffRole.Text;
        aStaff.StaffPrivilage = chkPrivilage.Checked;

        Response.Redirect("StaffViewer.aspx");
    }
}