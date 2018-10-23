<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Auction._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Net Auction</title>
<script language=javascript>
function focus()
{
    document.getElementById("TextBox1").focus()    
}
</script>
</head>
<body onload="focus()">
    <form id="form1" runat="server">
    <div style="background-attachment: fixed">
        <asp:Image ID="Image2" runat="server" Height="144px" ImageUrl="~/images/bike.jpg"
            Style="z-index: 100; left: 525px; position: absolute; top: 254px" Width="205px" />
        &nbsp; &nbsp;
        <asp:Image ID="Image3" runat="server" Height="144px" ImageUrl="~/images/Image1.jpg"
            Style="z-index: 101; left: 30px; position: absolute; top: 256px" Width="204px" />
        &nbsp;
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/add4.GIF" style="z-index: 102; left: 263px; position: absolute; top: 260px" Height="136px" Width="234px" />
        <table frame="box" style="z-index: 110; left: 447px; position: absolute; top: 109px">
            <tr>
                <td style="width: 100px">
                    User Name</td>
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
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
                <td style="width: 100px">
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" /></td>
            </tr>
        </table>
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Style="z-index: 103;
            left: 667px; position: absolute; top: 20px" OnClick="LinkButton1_Click">Admin</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Style="z-index: 104;
            left: 615px; position: absolute; top: 20px">Home</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server" Style="z-index: 105; left: 646px;
            position: absolute; top: 214px" OnClick="LinkButton3_Click" Font-Bold="True">Sign Up</asp:LinkButton>
        <asp:Label ID="Label1" runat="server" Style="z-index: 106; left: 573px; position: absolute;
            top: 213px" Text="New User"></asp:Label>
        &nbsp;
        <img src="images/TITLE.jpg" style="z-index: 114;
            left: 264px; width: 240px; position: absolute; top: 8px; height: 56px" />
        <img src="images/cart-central.jpg" style="z-index: 113; left: 504px; width: 54px;
            position: absolute; top: 8px; height: 56px" />
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img src="images/OnlineAuction.jpg" style="z-index: 111; left: 264px; width: 180px;
            position: absolute; top: 80px; height: 160px" />
        &nbsp;
        <img src="images/aucpeople.jpg" style="z-index: 112; left: 30px; width: 210px; position: absolute;
            top: 16px; height: 224px" />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Style="z-index: 109;
            left: 450px; position: absolute; top: 88px" Visible="False" Width="264px"></asp:Label>
        </div>
    </form>
</body>
</html>
