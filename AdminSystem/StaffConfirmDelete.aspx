<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Are you sure you want to delte this record?</p>
            <asp:Button ID="btnYes" runat="server"  style="z-index: 1;  position: absolute; top: 52px; left: 73px;" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; position: absolute; top: 53px; left: 154px;" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
