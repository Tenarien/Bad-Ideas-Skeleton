<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 86px; top: 316px; position: absolute" Text="Edit" />
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 8px; top: 92px; position: absolute; height: 187px; width: 336px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 316px; position: absolute" Text="Add" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 368px; position: absolute" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
