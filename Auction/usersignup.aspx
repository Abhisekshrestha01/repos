<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="Auction.usersignup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script language=javascript>
function focus()
{
    document.getElementById("txtname").focus()    
}
</script>
</head>
<body bgcolor="#eeedbb" onload="focus()">
    <form id="form1" runat="server">
    <div>
        <table id="Table1" border="1" cellpadding="1" cellspacing="1" style="z-index: 117;
            left: 408px; position: absolute; top: 38px" width="300">
            <tr>
                <td style="height: 28px; width: 130px;">
                    <asp:Label ID="Label2" runat="server">NAME</asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtname" runat="server" TabIndex="1" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 28px; width: 130px;">
                    <asp:Label ID="Label3" runat="server">USER NAME</asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtuname" runat="server" TabIndex="2" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label4" runat="server">PASSWORD</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TabIndex="3" TextMode="Password" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    Re-Write Password&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtrepwd" runat="server" Width="154px" TextMode="Password" TabIndex="4"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label5" runat="server">Mobile Number</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtmobile" runat="server" TabIndex="5" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label6" runat="server">E-Mail Id</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server" TabIndex="6" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label7" runat="server">CREDIT CARD NO</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtccno" runat="server" TabIndex="7" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label8" runat="server">STREET NAME</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtsname" runat="server" TabIndex="8" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label9" runat="server">CITY</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtcity" runat="server" TabIndex="9" Width="154px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label10" runat="server">COUNTRY</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtcountry" runat="server" Width="154px" TabIndex="10"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 130px; height: 28px">
                    <asp:Label ID="Label11" runat="server">PINCODE</asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtpincode" runat="server" TabIndex="11" Width="154px"></asp:TextBox></td>
            </tr>
        </table>
                    <asp:Button ID="btnreg" runat="server" TabIndex="12" Text="Submit" Font-Bold="True" style="z-index: 100; left: 432px; position: absolute; top: 392px" Width="84px" Height="24px" OnClick="btnreg_Click" />
                    <asp:Button ID="btnreset" runat="server" TabIndex="13" Text="Reset" Font-Bold="True" Height="24px" Width="72px" OnClick="btnreset_Click" style="z-index: 101; left: 594px; position: absolute; top: 392px" />
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" OnClick="LinkButton2_Click"
            Style="z-index: 102; left: 652px; position: absolute; top: 12px">Home</asp:LinkButton>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Style="z-index: 103;
            left: 174px; position: absolute; top: 384px" Visible="False" Width="198px"></asp:Label>
        &nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd"
            ControlToValidate="txtrepwd" ErrorMessage="Password Does not Match" Style="z-index: 104;
            left: 714px; position: absolute; top: 112px" Width="6px">*</asp:CompareValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
            ShowSummary="False" style="z-index: 105; left: 90px; position: absolute; top: 8px" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtname"
            ErrorMessage="Must Enter In Characters Only" Style="z-index: 106; left: 714px;
            position: absolute; top: 48px" ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtuname"
            ErrorMessage="Wrong" Style="z-index: 107; left: 714px; position: absolute; top: 80px"
            ValidationExpression="[/a-z A-Z 0-9 . _]{1,25}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtuname"
            ErrorMessage="Wrong" Style="z-index: 108; left: 714px; position: absolute; top: 80px"
            ValidationExpression="[/a-z A-Z 0-9 . _]{1,25}">*</asp:RegularExpressionValidator>
        &nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtmobile"
            ErrorMessage="Must Enter In Numerics Only" Style="z-index: 109; left: 714px;
            position: absolute; top: 176px" ValidationExpression="[/0-9]{1,25}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtemail"
            ErrorMessage="Must Enter Correct Email Id" Style="z-index: 110; left: 714px;
            position: absolute; top: 200px" ValidationExpression="[/a-z A-Z][\w\. -]*[/a-z A-Z 0-9]@[/a-z A-Z 0-9][\w\. -]*[/a-z A-Z 0-9]\.[/a-z A-Z][/a-z A-Z\.]*[/a-z A-Z]$">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server"
            ControlToValidate="txtpincode" ErrorMessage="Must Enter Correct PinCode" Style="z-index: 111;
            left: 714px; position: absolute; top: 368px" ValidationExpression="\d{6}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtccno"
            ErrorMessage="Must Enter Correct Format" Style="z-index: 112; left: 714px; position: absolute;
            top: 240px" ValidationExpression="[/a-z A-Z 0-9]{1,25}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtsname"
            ErrorMessage="Must Enter In Characters Only" Style="z-index: 113; left: 714px;
            position: absolute; top: 272px" ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtcity"
            ErrorMessage="Must Enter In Characters Only" Style="z-index: 114; left: 714px;
            position: absolute; top: 304px" ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="txtcountry"
            ErrorMessage="Must Enter In Characters Only" Style="z-index: 115; left: 714px;
            position: absolute; top: 328px" ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
        <img src="images/cart-central.jpg" style="z-index: 118; left: 42px; width: 312px;
            position: absolute; top: 53px; height: 320px" />
    
    </div>
    </form>
</body>
</html>

