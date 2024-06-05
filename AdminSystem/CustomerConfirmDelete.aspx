<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 557px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        <p style="height: 335px">
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" style="position: absolute; z-index: 1; left: 10px; top: 72px" />
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" style="position: absolute; z-index: 1; left: 147px; top: 70px" />
        </p>
    </form>
</body>
</html>
