<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About1.aspx.cs" Inherits="Auction.About1" %>

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
                    <asp:LinkButton ID="LinkButton5" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton2_Click" >Home</asp:LinkButton>
                </td>
                <td width ="9%">
                    <asp:LinkButton ID="LinkButton6" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton1_Click">Admin</asp:LinkButton>
                </td>
                <td width ="9%">
                    <asp:HyperLink ID="HyperLink5" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/About1.aspx"
            >About</asp:HyperLink>
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
            </tr>
        </table>
            </div>
        <div Style="background:#3E828F">
            <table>
                <tr>
                    <td width="35%">
                        <img id="img" src="images/OnlineAuction.jpg"/>
                    </td>
                    <td width="65%">
                        <h1>Online Auction</h1>
                        <br />

                       Online auction system is a more advance, easy, less time consuming and flexible solution for the conduction an auction using web. In this project we have described how we made an auction conducting website for seller and buyers. Our system can support large number of auctions. This online auction system allows the sellers to easily add the product they want to sell and set the time for auction to last. Also, buyers can securely buy things from the auction online. In this project we have implemented three different type of auction system namely straight auction which is traditional auction where a certain item is placed and all bidders know what the other bidders have bid before, second one is sealed auction which is a secure auction where bidders do not know the current bid other bidders have placed for the same item, and the last one is dutch auction where items can be sold in bulk to many people at one. Among these three types of auction only dutch auction is able for provide goods to multiple people. Our main objective was to develop a user-friendly site to be used for auction. For obtaining this we used dotNet, Microsoft Sql Server as our development tools. Result of the auction is also sent to the winners through email.
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                         <h1 align="center">To contact the Developer,please click Below</h1>
                        <p style="text-align:center;"><a href="Contact1.aspx">Developers</a></p>
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
