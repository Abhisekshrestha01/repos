﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admindel1.aspx.cs" Inherits="Auction.admindel1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
<!--

function IMG1_onclick() {

}

// -->
</script>
</head>
<body style="width: 1024px;
margin:0px auto;
text-align:left;" >
    <form id="form1" runat="server">
        <div Style="background:#006699;">
         <table >
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
                    <asp:Label ID="Label5" runat="server" Text="ADMIN"></asp:Label>
                </td>
                <td width ="9%">
                  <asp:HyperLink ID="HyperLink6" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/Logout1.aspx"
            >LogOut</asp:HyperLink>
                </td>
            </tr>
        </table>
        <div Style="background:#3E828F">
            <table width="100%">
                <tr>
                    <td style="text-align:center">
                        <img id="IMG1" src="images/recyclebin.png"  language="javascript" onclick="return IMG1_onclick()" />
                    </td>
                    <td width="20%">
                        <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/adminmain1.aspx"
            >Back</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Height="24px" NavigateUrl="~/stadmindel1.aspx"
             Width="110px">Straight Auction</asp:HyperLink>
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Height="24px" NavigateUrl="~/admindaudel1.aspx"
             Width="108px">dutch Auction</asp:HyperLink>
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Height="24px" NavigateUrl="~/adminseadel1.aspx"
             Width="108px">Sealed Auction</asp:HyperLink>
                    </td>
                    <td>

                    </td>
                </tr>
            </table>
        <div Style="background:#006699">
            <h3 align="center"> CopyRight Lamar University  </h3>
        </div>
      
    </div>
    </form>
</body>
</html>
