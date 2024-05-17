<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            This is the AddressBook Data Entry page</p>
        <asp:Label ID="lblAddressId" runat="server" style="z-index: 1; left: 24px; top: 68px; position: absolute; width: 101px" Text="SupplierId"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 161px; top: 70px; position: absolute;"></asp:TextBox>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 160px; top: 115px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtContractDate" runat="server" style="z-index: 1; left: 160px; top: 169px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 20px; top: 117px; position: absolute" Text="SupplierName" width="101px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblContractDate" runat="server" style="z-index: 1; left: 21px; top: 173px; position: absolute" Text="ContractDate" width="101px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TxtAvailableSupplier" runat="server" style="z-index: 1; left: 160px; top: 217px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplierAddress" runat="server" style="z-index: 1; left: 19px; top: 273px; position: absolute" Text="SupplierAddress"></asp:Label>
        <asp:TextBox ID="TxtSupplierAddress" runat="server" style="z-index: 1; left: 157px; top: 269px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAvailableSupplier" runat="server" style="z-index: 1; left: 20px; top: 223px; position: absolute; height: 19px" Text="AvailableSupplier" width="101px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 26px; top: 337px; position: absolute; height: 15px; width: 54px" Text="[IBIError]"></asp:Label>
        <p>
            <asp:CheckBox ID="chkAvailableSupplier" runat="server" style="z-index: 1; left: 246px; top: 336px; position: absolute" Text="AvailableSupplier" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 290px; top: 412px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" style="z-index: 1; left: 69px; top: 423px; position: absolute; width: 40px; height: 21px" Text="OK" />
    </form>
</body>
</html>
