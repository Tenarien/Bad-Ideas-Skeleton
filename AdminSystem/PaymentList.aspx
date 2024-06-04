<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is Payments List page
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstPaymentList" runat="server" Height="314px" Width="391px"></asp:ListBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 305px; top: 493px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 324px; top: 388px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 18px; top: 391px; position: absolute;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 174px; top: 390px; position: absolute;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 48px; top: 560px; position: absolute; width: 95px; right: 829px;" Text="Apply Filter" />
            <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 82px; top: 498px; position: absolute"></asp:TextBox>
          <asp:Label ID="lblPaymentMethod" runat="server" style="z-index: 1; left: 72px; top: 459px; position: absolute" Text="Enter Payment Method"></asp:Label>
        </div>
            <asp:Button ID="lblClearFilter" runat="server" OnClick="lblClearFilter_Click" style="z-index: 1; left: 212px; top: 559px; position: absolute; width: 89px;" Text="Clear Filter" />
        <asp:Button ID="btnTeamMainMenu" runat="server" OnClick="btnTeamMainMenu_Click" style="z-index: 1; left: 460px; top: 387px; position: absolute" Text="Return to Team Main Menu" />
    </form>
</body>
</html>
