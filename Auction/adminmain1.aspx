<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminmain1.aspx.cs" Inherits="Auction.adminmain1" %>

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
                  <asp:HyperLink ID="HyperLink5" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/Logout1.aspx"
            >LogOut</asp:HyperLink>
                </td>
            </tr>
        </table>
            </div>
        <div Style="background:#3E828F">
            <table width="100%" style="text-align:center">
                <tr>
                    <td>
                        <img id="IMG1" src="images/admin.gif" language="javascript" onclick="return IMG1_onclick()" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/adminviewreport1.aspx"
            >View Reports</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True"  NavigateUrl="~/admindel1.aspx">Delete Items</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                      <!--  <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/adminresults1.aspx"
            >Results</asp:HyperLink> -->
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
