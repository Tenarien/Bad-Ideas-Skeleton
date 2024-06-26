﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBookId" runat="server" style="z-index: 1; left: 12px; top: 33px; position: absolute" Text="Book ID" width="75px"></asp:Label>
        <asp:TextBox ID="txtBookId" runat="server" style="z-index: 1; left: 112px; top: 32px; position: absolute" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 282px; top: 30px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 112px; top: 90px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Title" width="75px"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 148px; position: absolute; right: 1175px;" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 112px; top: 147px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Price" width="75px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 112px; top: 204px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 11px; top: 258px; position: absolute; right: 2064px;" Text="Quantity" width="75px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 112px; top: 257px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 10px; top: 308px; position: absolute; right: 2065px" Text="Supplier ID" width="75px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 112px; top: 307px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 112px; top: 351px; position: absolute" Text="Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 112px; top: 396px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; left: 169px; top: 444px; position: absolute; right: 1896px;" Text="Cancel" height="26px" Width="60px" OnClick="btnCancel_Click"/>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 112px; top: 444px; position: absolute; height: 26px;" Text="OK" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 253px; top: 444px; position: absolute; width: 137px; height: 26px;" Text="Return to Main Menu" />
    </form>
</body>
</html>
