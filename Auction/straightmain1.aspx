﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="straightmain1.aspx.cs" Inherits="Auction.straightmain1" %>

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
                          <asp:HyperLink ID="HyperLink4" runat="server" style="text-align:right;" Font-Bold="True" NavigateUrl="~/usermain1.aspx" 
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
                          <asp:Image ID="Image1" runat="server" ImageUrl="~/images/zedge1039nl.jpg"  />
                     </td>
                      <td>

                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:HyperLink ID="HyperLink1" style="text-decoration:none;" runat="server" Font-Bold="True" NavigateUrl="stauserview1.aspx"
            >View Items</asp:HyperLink>
                     </td>
                      <td>

                     </td>
                 </tr>
                 <tr>
                     <td>
                          <asp:HyperLink ID="HyperLink3" style="text-decoration:none" runat="server" Font-Bold="True" NavigateUrl="~/stausersell1.aspx"
            >Item Registation</asp:HyperLink>
                     </td>
                      <td>
                         
                     </td>
                 </tr>
                 <tr>
                     <td>
                        <!--  <asp:HyperLink ID="HyperLink2" style="text-decoration:none" runat="server" Font-Bold="True" NavigateUrl="~/stauserbuy1.aspx"
            >Buy</asp:HyperLink>-->
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
