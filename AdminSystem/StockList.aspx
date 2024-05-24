<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="331px" Width="321px" style="z-index: 1; left: 10px; top: 15px; position: absolute"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 370px; position: absolute; bottom: 476px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 62px; position: absolute; bottom: 252px;" Text="Edit" height="26" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 508px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 115px; position: absolute; bottom: 252px;" Text="Delete" height="26" />
        <p>
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 10px; top: 425px; position: absolute" Text="Enter a Title"></asp:Label>
        </p>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 105px; top: 424px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 10px; top: 466px; position: absolute" Text="Apply Filter" />
        </p>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 128px; top: 466px; position: absolute; width: 100px" Text="Clear Filter" />
    </form>
</body>
</html>
