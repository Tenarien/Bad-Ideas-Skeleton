<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="SupplierLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPage" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Supplier Login Page"></asp:Label>
        </div>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 70px; top: 97px; position: absolute" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 201px; top: 98px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 70px; top: 146px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 203px; top: 145px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 139px; top: 206px; position: absolute; width: 60px; height: 26px" Text="Login" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 425px; top: 146px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 206px; position: absolute; width: 60px; left: 282px; height: 26px" Text="Cancel" OnClick="btnCancel_Click" />       
    </form>
</body>
</html>
