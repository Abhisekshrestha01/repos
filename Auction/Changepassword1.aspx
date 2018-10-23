<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Changepassword1.aspx.cs" Inherits="Auction.Changepassword1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 1024px;
margin:0px auto;
text-align:left;" onload = "startTimer()">
    <form id="form1" runat="server">
        <div Style="background:#006699;">
         <table>
             <tr>
                 <td width="5%">
                     <img src="images/logo.png" height="95px" width="95px" />
                 </td>
                 <td width="95%">
                     <p style="height:30px; font-size:60px; text-shadow: 3px 2px green;">Online Auction system</p>
                 </td>
             </tr>
         </table>
            
        <table width="100%" bgcolor="#D7DDD1">
            <tr>
                <td width ="9%">

                </td>
                <td width ="9%">

                </td>
                <td width ="9%">

                </td>
                <td width ="9%">

                </td>
                <td width ="9%">

                </td>
                <td width ="9%">

                </td>
                <td width ="9%">

                </td>
                <td width ="9%">

                </td>
                 <td width ="9%">

                </td>
                <td width ="9%">
                     <asp:LinkButton ID="LinkButton5" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton1_Click">Home</asp:LinkButton>
                </td>
                <td width ="9%">
                    <asp:LinkButton ID="LinkButton6" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton2_Click">Admin</asp:LinkButton>
                </td>
            </tr>
        </table>
            </div>
        <div Style="background:#3E828F">
        
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label2" runat="server" Text="What is your mother's name:"></asp:Label>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="txtmothername" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label3" runat="server" Text="Mobile No."></asp:Label>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="txtmobileno" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                   
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:Button ID="btn_save" OnClick="Button1_Click" runat="server" Text="Save" />&nbsp;
                    <asp:Button ID="btn_reset" OnClick="btn_reset_Click" runat="server" Text="Reset" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
            <div Style="background:#006699">
            <h3 align="center"> CopyRight Lamar University  </h3>
        </div>
            </div>
    </form>
</body>
</html>
