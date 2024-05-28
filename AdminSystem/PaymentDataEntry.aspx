<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:Label ID="lblPaymentID" runat="server" style="z-index: 1; left: 12px; top: 33px; position: absolute; width: 153px;" Text="Payment ID"></asp:Label>
        <asp:TextBox ID="txtPaymentID" runat="server" style="z-index: 1; left: 158px; top: 32px; position: absolute; right: 678px;" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 347px; top: 29px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtPaymentDate" runat="server" style="z-index: 1; left: 158px; top: 87px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPaymentDate" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Payment Date" width="153px"></asp:Label>
        <asp:Label ID="lblPaymentMethod" runat="server" style="z-index: 1; left: 10px; top: 148px; position: absolute; right: 809px;" Text="Payment Method"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 157px; top: 145px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblAmount" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Amount" width="153px"></asp:Label>
        <asp:TextBox ID="txtAmount" runat="server" style="z-index: 1; left: 156px; top: 205px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCurrency" runat="server" style="z-index: 1; left: 11px; top: 258px; position: absolute; right: 2064px;" Text="Currency" width="153px"></asp:Label>
        <asp:TextBox ID="txtCurrency" runat="server" style="z-index: 1; left: 161px; top: 256px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkStatusCleared" runat="server" style="z-index: 1; left: 153px; top: 313px; position: absolute" Text="Status Cleared" />
        <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; top: 408px; position: absolute; right: 744px;" Text="Cancel" height="26px" Width="60px" OnClick="btnCancel_Click"/>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 41px; top: 407px; position: absolute; height: 26px;" Text="OK" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 100px; top: 369px; position: absolute"></asp:Label>
    </form>
</body>
</html>
