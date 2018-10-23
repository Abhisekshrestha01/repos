<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seausersell.aspx.cs" Inherits="Auction.seausersell" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script language=javascript>
function focus()
{
    document.getElementById("TextBox2").focus()    
}
</script>
</head>
<body bgcolor="#eeedbb" onload="focus()">
    <form id="form1" runat="server">
    <div>
        <table frame="box" style="z-index: 110; left: 252px; position: absolute; top: 96px">
            <tr>
                <td style="width: 109px">
                    <strong>Customer Id</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" TabIndex="1"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Item Name</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server" TabIndex="2"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Initial Cost</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox3" runat="server" TabIndex="3"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Increment Cost</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server" TabIndex="4"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Item Desc</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5" runat="server" TabIndex="5"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>No. Of Days</strong></td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList1" runat="server" TabIndex="6" Width="156px">
                        <asp:ListItem>----Select----</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
        </table>
        <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True" NavigateUrl="~/Default.aspx"
            Style="z-index: 100; left: 666px; position: absolute; top: 16px">Home</asp:HyperLink>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/seausermain.aspx"
            Style="z-index: 101; left: 606px; position: absolute; top: 16px">Back</asp:HyperLink>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 102;
            left: 288px; position: absolute; top: 288px" Text="Submit" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="z-index: 103;
            left: 414px; position: absolute; top: 288px" Text="Reset" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="Must Enter Charecters Only" Style="z-index: 104; left: 540px; position: absolute;
            top: 136px" ValidationExpression="[/a-z A-Z]{1,15}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3"
            ErrorMessage="Must Enter Digits Only" Style="z-index: 105; left: 540px; position: absolute;
            top: 168px" ValidationExpression="[/0-9]{1,15}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox4"
            ErrorMessage="Must Enter Digits Only" Style="z-index: 106; left: 540px; position: absolute;
            top: 192px" ValidationExpression="[/0-9]{1,15}">*</asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox5"
            ErrorMessage="Must Enter Charecters Only" Style="z-index: 107; left: 540px; position: absolute;
            top: 224px" ValidationExpression="[/a-z A-Z]{1,15}">*</asp:RegularExpressionValidator>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Style="z-index: 108;
            left: 340px; position: absolute; top: 72px" Visible="False" Width="192px"></asp:Label>
        &nbsp;&nbsp;
        <img src="images/zedge1763nl.jpg" style="z-index: 111; left: 264px; width: 258px;
            position: absolute; top: 0px; height: 48px" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="z-index: 112; left: 354px;
            position: absolute; top: 48px" Text="                      Register" Width="114px"></asp:Label>
    
    </div>
    </form>
</body>
</html>

