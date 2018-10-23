<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="Auction.Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script language=javascript>
function focus()
{
    document.getElementById("TextBox1").focus()    
}
function IMG1_onclick() {

}

</script>
</head>
<body bgcolor="#eeedbb" onload="focus()">
    <form id="form1" runat="server">
    <div>
        <table frame="box" style="z-index: 103; left: 447px; position: absolute; top: 109px">
            <tr>
                <td style="width: 100px">
                    User Id</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="146px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Password</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="146px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" /></td>
                <td style="width: 100px">
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" /></td>
            </tr>
        </table>
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" OnClick="LinkButton2_Click"
            Style="z-index: 100; left: 666px; position: absolute; top: 24px">Home</asp:LinkButton>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Style="z-index: 101;
            left: 450px; position: absolute; top: 88px" Visible="False" Width="264px"></asp:Label>
        &nbsp; &nbsp; &nbsp;
        <img src="images/ADMINI.jpg" style="z-index: 104; left: 174px; width: 258px; position: absolute;
            top: 16px; height: 56px" />
        &nbsp;
        <img src="images/login_splash.jpg" style="z-index: 105; left: 174px; width: 258px;
            position: absolute; top: 72px; height: 248px" />
    
    </div>
    </form>
</body>
</html>

