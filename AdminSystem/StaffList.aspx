<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="331px" Width="321px"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 68px; top: 346px; position: absolute" Text="Edit" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 346px; position: absolute" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 132px; top: 346px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        </div>
        <div>            
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 9px; top: 403px; position: absolute">Enter a Staff Name</asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 142px; top: 402px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 29px; top: 428px; position: absolute;" Text="ApplyFilter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; top: 428px; position: absolute; left: 152px" Text="Clear Filter" /> 
        </div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 7px; top: 511px; position: absolute" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
