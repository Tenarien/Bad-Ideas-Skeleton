<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            position: relative;
        }
    </style>
</head>
<body style="height: 780px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="406px" Width="414px"></asp:ListBox>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" height="26px" style="z-index: 1; left: 5px; top: 1px; position: relative" width="55px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 28px; top: 1px; position: relative" Text="Add" height="26px" width="55px" />
        </p>
        <asp:Label ID="lblEnterEmail" runat="server" Text="Enter an Email"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 2; left: 76px; top: -40px; position: relative" Text="Edit" height="26px" width="55px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: -1px; top: 627px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" Height="22px" style="position: relative; top: 5px; left: -29px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="position: relative" />
        </p>
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 0px; top: 581px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
