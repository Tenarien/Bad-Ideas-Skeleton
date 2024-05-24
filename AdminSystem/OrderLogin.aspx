    <title></title>
<form id="form1" runat="server">
    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

&nbsp;

<!DOCTYPE html>
    <script runat="server">
</script>


    <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
</body>
</html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <body>
        <p>
            <asp:Label ID="lblOrderProcessing" runat="server" style="z-index: 1; left: 7px; top: 64px; position: absolute" Text="Order Processing Login Page "></asp:Label>
        </p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 96px; top: 204px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 97px; top: 252px; position: absolute; bottom: 394px" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 215px; top: 202px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 216px; top: 254px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 426px; top: 240px; position: absolute" Text="[lblError]" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 221px; top: 329px; position: absolute; right: 294px;" Text="Login" OnClick="btnLogin_Click" width="60px" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 300px; top: 328px; position: absolute" Text="Cancel" />
</body>
</html>
</form>

