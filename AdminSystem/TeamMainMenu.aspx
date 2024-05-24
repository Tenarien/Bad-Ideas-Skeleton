<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMenuHeader" runat="server" style=" font-size: 40px; left: 140px; top: 95px; position: absolute" Text="Bad Ideas Main Menu"></asp:Label>
        <asp:Button ID="btnStaff" runat="server" height="26px" OnClick="btnStaff_Click" style="z-index: 1; left: 74px; top: 185px; position: absolute" Text="Staff" width="84px" />
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; top: 184px; position: absolute; right: 395px" Text="Customer" />
        <asp:Button ID="btnOrder" runat="server" height="26px" OnClick="btnOrder_Click" style="z-index: 1; left: 290px; top: 183px; position: absolute; right: 290px" Text="Order" width="84px" />
        <asp:Button ID="btnStock" runat="server" height="26px" OnClick="btnStock_Click" style="z-index: 1; left: 396px; top: 183px; position: absolute; right: 291px" Text="Stock" width="84px" />
        <asp:Button ID="btnSupplier" runat="server" height="26px" OnClick="btnSupplier_Click" style="z-index: 1; left: 522px; top: 183px; position: absolute" Text="Supplier" width="84px" />
    </form>
</body>
</html>
