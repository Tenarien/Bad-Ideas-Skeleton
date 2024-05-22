<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 56px; top: 232px; position: absolute; width: 78px" Text="Yes" />
        <p>
            <asp:Label ID="lblDeleteRecord" runat="server" style="z-index: 1; left: 39px; top: 182px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" OnClick="Button1_Click" style="z-index: 1; top: 231px; position: absolute; right: 498px; left: 175px" Text="No" width="78px" />
    </form>
</body>
</html>
