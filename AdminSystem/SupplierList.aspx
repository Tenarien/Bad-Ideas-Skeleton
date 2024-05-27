<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style =" height:584px">
            <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 11px; top: 15px; position: absolute; height: 285px; width: 406px"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 90px; top: 337px; position: absolute; height: 29px; width: 48px;" Text="Edit" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 36px; top: 506px; position: absolute"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 68px; top: 393px; position: absolute; width: 182px; right: 722px" Text="Enter Supplier Name"></asp:Label>
            <asp:TextBox ID="txtSupplierNameFilter" runat="server" style="z-index: 1; left: 73px; top: 432px; position: absolute"></asp:TextBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 30px; top: 337px; position: absolute; height: 29px;  width: 48px; " Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 155px; top: 336px; position: absolute; width: 52px" Text="Delete" height="29px" />
    </form>
</body>
</html>
