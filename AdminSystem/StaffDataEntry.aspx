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
        <div>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 76px; top: 10px; position: absolute; width: 128px; " Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 228px; top: 10px; position: absolute;" height="22px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" style="z-index: 1; left: 446px; top: 10px; position: absolute;" OnClick="btnFind_Click" />
        </div>
        <div>
            <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 76px; top: 40px; position: absolute" Text="Staff Name" width="128px"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 228px; top: 40px; position: absolute" height="22px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffAdress" runat="server" style="z-index: 1; left: 76px; top: 70px; position: absolute" Text="Staff Address" width="128px"></asp:Label>
            <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 228px; top: 70px; position: absolute" height="22px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffDate" runat="server" style="z-index: 1; left: 76px; top: 100px; position: absolute" Text="Date Added" width="128px"></asp:Label>
            <asp:TextBox ID="txtStaffDate" runat="server" style="z-index: 1; left: 228px; top: 100px; position: absolute" height="22px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 76px; top: 130px; position: absolute; height: 19px; width: 128px" Text="Staff Role"></asp:Label>
            <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 228px; top: 130px; position: absolute" height="22px"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="chkPrivilage" runat="server" style="z-index: 1; left: 232px; top: 160px; position: absolute; " Text="Privilage" width="480" />
        </div>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 318px; top: 267px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 225px; top: 267px; position: absolute;" Text="Confirm" />
        <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 411px; top: 267px; position: absolute; height: 26px; width: 153px" Text="Return to Main Menu" OnClick="btnReturn_Click" />
    </form>
     <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 76px; top: 187px; position: absolute; width: 562px; height: 69px;" Text="" ForeColor="Red"></asp:Label>
</body>
</html>
