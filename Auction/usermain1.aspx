<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usermain1.aspx.cs" Inherits="Auction.usermain1" %>

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
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td width ="9%">
                  <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/Logout1.aspx"
            >LogOut</asp:HyperLink>
                </td>
            </tr>
        </table>
            </div>
        <div Style="background:#3E828F">
            <table width="85%" align="center">
                <tr>
                    <td>
                         <img src="images/Image1.jpg" width=375px; 
            height=331px" />
                    </td>
                    <td width="30%">

                    </td>
                    <td>
                        <table>
                            <tr>
                                <td align="top">
                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" style="font-size:40px" ForeColor="Black"></asp:Label>
                                  
                                </td>
                            </tr>
                            <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>
                                     <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="straightmain1.aspx"
            >Straight Auction</asp:HyperLink>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                     <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" NavigateUrl="~/dauusermain1.aspx"
           >dutch Auction</asp:HyperLink>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" NavigateUrl="seausermain1.aspx"
           >Sealed Auction</asp:HyperLink>
                                </td>
                            </tr>
                             <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>

                                </td>
                            </tr>
                             <tr>
                                <td>
                                     <asp:Label ID="Label2" runat="server" Font-Bold="True"  Text="To view the Results Click Here" Width="216px"></asp:Label>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                     <asp:HyperLink ID="HyperLink7" runat="server" Font-Bold="True" NavigateUrl="~/userresults1.aspx"
            >Results</asp:HyperLink>
                                </td>
                            </tr>
                        </table>
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
