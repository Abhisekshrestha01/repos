<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dauusermain1.aspx.cs" Inherits="Auction.dauusermain1" %>

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
         <table >
             <tr>
                 <td width="5%">
                     <img src="images/logo.png" height="95px" width="95px" />
                 </td>
                 <td width="95%">
                     <p style="height:30px; font-size:60px; style="text-decoration:none;" text-shadow: 3px 2px green;">Online Auction system</p>
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
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td width ="9%">
                  <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True" NavigateUrl="~/Logout1.aspx"
            >LogOut</asp:HyperLink>
                </td>
            </tr>
        </table>
            </div >
         <div Style="background:#3E828F">
             </br>
             <table width="85%" align="center">
                 <tr>
                     <td>
                         <img src="images/background.jpg" width=375px; 
            height=331px" />
                     </td>
                     <td>
                         <table>
                             <tr>
                     <td>

                     </td>
                     <td>
                          <asp:HyperLink ID="HyperLink6" runat="server" style="text-align:right;" Font-Bold="True" NavigateUrl="~/usermain1.aspx" 
            >Back</asp:HyperLink>
                     </td>
                 </tr>
                             <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                              <tr><td></td></tr>
                 <tr>
                     <td>
                          <asp:Image ID="Image1" runat="server" ImageUrl="~/images/dau.jpg"  />
                     </td>
                      <td>

                     </td>
                 </tr>
                 <tr>
                     <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/dauuserview1.aspx"
            >View Items</asp:HyperLink>
                     </td>
                      <td>

                     </td>
                 </tr>
                 <tr>
                     <td>
                          <asp:HyperLink ID="HyperLink3" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/dauusersell1.aspx"
            >Item Registation</asp:HyperLink>
                     </td>
                      <td>
                         
                     </td>
                 </tr>
                 <tr>
                     <td>
                        <!-- <asp:HyperLink ID="HyperLink2" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/dauuserbuy1.aspx"
            >Buy</asp:HyperLink> -->
                     </td>
                      <td>

                     </td>
                 </tr>
                         </table>
                     </td>
                 </tr>
                 
             </table>
        
        
       
       
       
        &nbsp;
       
     <div Style="background:#006699">
            <h3 align="center"> CopyRight Lamar University  </h3>
        </div>
    </div>
    </form>
        
</body>
</html>
