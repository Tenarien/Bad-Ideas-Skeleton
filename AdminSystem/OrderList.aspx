<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 118px; top: 320px; position: absolute" Text="Edit" width="55px" />
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 8px; top: 92px; position: absolute; height: 187px; width: 336px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 28px; top: 320px; position: absolute" Text="Add" width="55px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 484px; position: absolute" Text="lblError"></asp:Label>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 21px; top: 433px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 154px; top: 432px; position: absolute" Text="Clear Filter" />
        </p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 204px; top: 320px; position: absolute; height: 26px;" Text="Delete" />
            <asp:Label ID="lblEnterShippingAddress" runat="server" style="z-index: 1; left: 34px; top: 385px; position: absolute" Text="Enter a Shipping Address"></asp:Label>
        <asp:TextBox ID="txtEnterShippimgAddress" runat="server" style="z-index: 1; left: 224px; top: 380px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
