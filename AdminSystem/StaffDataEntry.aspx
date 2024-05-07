<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 557px;
        }
    </style>
</head>
<body style="height: 563px">
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 76px; top: 19px; position: absolute; width: 52px;" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 164px; top: 18px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 77px; top: 125px; position: absolute; height: 19px; width: 70px" Text="Staff Role"></asp:Label>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 78px; top: 46px; position: absolute" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 164px; top: 43px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffAdress" runat="server" style="z-index: 1; left: 76px; top: 74px; position: absolute" Text="Staff Address"></asp:Label>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 164px; top: 71px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffDate" runat="server" style="z-index: 1; left: 78px; top: 99px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtStaffDate" runat="server" style="z-index: 1; left: 163px; top: 98px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 163px; top: 124px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPrivilage" runat="server" style="z-index: 1; left: 180px; top: 161px; position: absolute; right: 962px" Text="Privilage" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 80px; top: 187px; position: absolute" Text="Error"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 162px; top: 201px; position: absolute" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 238px; top: 201px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
