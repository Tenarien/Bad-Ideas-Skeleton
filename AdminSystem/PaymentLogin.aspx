<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentLogin.aspx.cs" Inherits="PaymentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderProcessing" runat="server" style="z-index: 1; left: 173px; top: 102px; position: absolute" Text="Payments Login Page "></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 96px; top: 204px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 97px; top: 252px; position: absolute; bottom: 291px; right: 791px;" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 215px; top: 202px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 216px; top: 254px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 183px; top: 305px; position: absolute; right: 710px;" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 85px; top: 351px; position: absolute; right: 827px;" Text="Login" OnClick="btnLogin_Click" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 288px; top: 350px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
