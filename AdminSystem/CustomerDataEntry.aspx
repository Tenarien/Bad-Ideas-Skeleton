<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" height="19px" style="z-index: 1; left: 13px; top: 35px; position: absolute" Text="CustomerId" width="85px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="txtCustomerId_TextChanged" style="z-index: 1; left: 115px; top: 31px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtCustomerSurname" runat="server" OnTextChanged="txtCustomerSurname_TextChanged" style="z-index: 1; left: 115px; top: 109px; position: absolute; margin-bottom: 6px"></asp:TextBox>
            <asp:TextBox ID="txtCustomerFirstName" runat="server" OnTextChanged="txtCustomerFirstName_TextChanged" style="z-index: 1; left: 115px; top: 72px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerSurname" runat="server" height="19px" style="z-index: 1; left: 13px; top: 110px; position: absolute" Text="Surname" width="85px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCustomerFirstName" runat="server" height="19px" style="z-index: 1; left: 13px; top: 73px; position: absolute" Text="First Name" width="85px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCustomerEmail" runat="server" height="19px" style="z-index: 1; left: 13px; top: 146px; position: absolute" Text="Email" width="85px"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 115px; top: 147px; position: absolute; right: 965px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerAddress" runat="server" height="19px" style="z-index: 1; left: 14px; top: 186px; position: absolute" Text="Address" width="85px"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server" OnTextChanged="TextBox3_TextChanged" style="z-index: 1; left: 114px; top: 183px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerAccountCreationDate" runat="server" style="z-index: 1; left: 13px; top: 224px; position: absolute" Text="Creation Date"></asp:Label>
            <asp:TextBox ID="txtCustomerAccountCreationDate" runat="server" OnTextChanged="txtCustomerAccountCreationDate_TextChanged" style="z-index: 1; left: 116px; top: 222px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" OnCheckedChanged="chkActive_CheckedChanged" style="z-index: 1; left: 116px; top: 262px; position: absolute; right: 353px" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 300px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 338px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; top: 339px; position: absolute; left: 71px; height: 26px; bottom: 274px" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
