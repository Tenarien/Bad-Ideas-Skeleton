<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="331px" Width="321px" style="z-index: 1; left: 9px; top: 42px; position: absolute"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 9px; position: absolute; height: 26px; top: 394px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 63px; position: absolute; top: 394px;" Text="Edit" height="26" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 534px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 117px; position: absolute; top: 394px;" Text="Delete" height="26" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 9px; top: 450px; position: absolute" Text="Enter a Title"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 105px; top: 450px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 9px; top: 492px; position: absolute; height: 26px;" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 128px; top: 492px; position: absolute; width: 100px; height: 26px;" Text="Clear Filter" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 247px; top: 492px; position: absolute; width: 140px; height: 26px;" Text="Return to Main Menu" />
    </form>
</body>
</html>
