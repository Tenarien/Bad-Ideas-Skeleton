﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

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
        <asp:Button ID="btnCustomer" runat="server" height="26px" OnClick="btnCustomer_Click" style="z-index: 1; left: 175px; top: 185px; position: absolute; right: 375px" Text="Customer" Width="84px" />
        <asp:Button ID="btnOrder" runat="server" height="26px" OnClick="btnOrder_Click" style="z-index: 1; left: 275px; top: 185px; position: absolute;" Text="Order" width="84px" />
        <asp:Button ID="btnStock" runat="server" height="26px" OnClick="btnStock_Click" style="z-index: 1; left: 375px; top: 185px; position: absolute;" Text="Stock" width="84px" />
        <asp:Button ID="btnSupplier" runat="server" height="26px" OnClick="btnSupplier_Click" style="z-index: 1; left: 475px; top: 185px; position: absolute" Text="Supplier" width="84px" />
        <asp:Button ID="btnPayment" runat="server" height="26px" style="z-index: 1; left: 575px; top: 185px; position: absolute" Text="Payment" width="84px" OnClick="btnPayment_Click" />
    </form>
</body>
</html>
