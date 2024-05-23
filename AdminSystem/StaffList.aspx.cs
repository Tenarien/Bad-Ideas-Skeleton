using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }
    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();

        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;

        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;

        if(lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;

            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["Staffid"] = StaffId;

            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection aStaff = new clsStaffCollection();

        aStaff.ReportByName(txtFilter.Text);

        lstStaffList.DataSource = aStaff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";

        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection aStaff = new clsStaffCollection();

        aStaff.ReportByName("");

        txtFilter.Text = "";

        lstStaffList.DataSource = aStaff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";

        lstStaffList.DataBind();
    }
}