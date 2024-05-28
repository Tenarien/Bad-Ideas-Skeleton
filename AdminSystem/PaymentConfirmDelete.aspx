<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblText" runat="server" Text="Are you want to delete this?"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" Text="Yes" />
        </p>
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </p>
    </form>
</body>
</html>
