using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            if(StaffId != -1)
            {
                DisplayStaff();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();

        string StaffName = txtStaffName.Text;
        string StaffAddress = txtStaffAddress.Text;
        string StaffDate = txtStaffDate.Text;
        string StaffRole = txtStaffRole.Text;
        string StaffPrivilage = chkPrivilage.Text;

        string Error = "";

        Error = aStaff.Valid(StaffName, StaffAddress, StaffDate, StaffRole);
        if (Error == "")
        {
            aStaff.StaffId = StaffId;
            aStaff.StaffName = StaffName;
            aStaff.StaffAddress = StaffAddress;
            aStaff.StaffDate = Convert.ToDateTime(StaffDate);
            aStaff.StaffRole = StaffRole;
            aStaff.StaffPrivilage = chkPrivilage.Checked;

            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffId == -1)
            {
                StaffList.ThisStaff = aStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = aStaff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ThisStaff.Find(StaffId);

        txtStaffName.Text = Staff.ThisStaff.StaffName.ToString();
        txtStaffAddress.Text = Staff.ThisStaff.StaffAddress.ToString();
        txtStaffDate.Text = Staff.ThisStaff.StaffDate.ToString();
        txtStaffRole.Text = Staff.ThisStaff.StaffRole.ToString();
        chkPrivilage.Checked = Staff.ThisStaff.StaffPrivilage;
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}