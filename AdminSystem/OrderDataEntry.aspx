<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>

            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 130px; top: 55px; position: absolute" width="128px"></asp:TextBox>

        </p>
        <p>
            <asp:Label ID="lblOrderId0" runat="server" style="z-index: 1; left: 6px; top: 56px; position: absolute" Text="Order ID" width="107px"></asp:Label>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 6px; top: 91px; position: absolute" Text="Customer ID" width="107px"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 130px; top: 114px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 130px; top: 87px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 130px; top: 143px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 6px; top: 136px; position: absolute; height: 19px; margin-top: 8px" Text="Order Date" width="107px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 6px; top: 179px; position: absolute" Text="Total Price" width="107px"></asp:Label>
        <p>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 130px; position: absolute; top: 175px" width="128px"></asp:TextBox>
            <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 6px; top: 204px; position: absolute" Text="Shipping Address"></asp:Label>
            <asp:TextBox ID="txtShippingAddress" runat="server" style="z-index: 1; left: 130px; top: 205px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:CheckBox ID="chkShippingStatus" runat="server" style="z-index: 1; left: 51px; top: 235px; position: absolute" Text="Shipping Status" />
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 324px; position: absolute" Text="OK" width="60px" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 325px; top: 53px; position: absolute" Text="Find" width="60px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 271px; position: absolute; height: 21px"></asp:Label>
        <p>
            <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 294px; top: 323px; position: absolute" Text="Return to Main Menu" />
        </p>
        <p>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 6px; top: 121px; position: absolute" Text="Staff ID"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 119px; top: 324px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
