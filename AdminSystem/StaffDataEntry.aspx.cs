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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();

        Int32 StaffId;

        Boolean Found = false;

        StaffId = Convert.ToInt32(txtStaffId.Text);

        Found = aStaff.Find(StaffId);

        if (Found)
        {
            txtStaffName.Text = aStaff.StaffName;
            txtStaffAddress.Text = aStaff.StaffAddress;
            txtStaffDate.Text = aStaff.StaffDate.ToString();
            txtStaffRole.Text = aStaff.StaffRole;
            chkPrivilage.Checked = aStaff.StaffPrivilage;
            
        }
    }
}