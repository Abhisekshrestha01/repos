<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact1.aspx.cs" Inherits="Auction.Contact1" %>

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
                    <asp:LinkButton ID="LinkButton5" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton1_Click" >Home</asp:LinkButton>
                </td>
                <td width ="9%">
                    <asp:LinkButton ID="LinkButton6" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton2_Click">Admin</asp:LinkButton>
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
                    <td width="32%">
                        <table>
                            <tr>
                                <td>
                                    <img id="img" width="190px" height="190px" src="images/Abhisek_shrestha.jpg"/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Name : Abhisek Shrestha
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Email : abhisek.shrestha1991@gmail.com
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Computer Science Department, Lamar University
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td width="32%">
                        <table>
                            <tr>
                                <td>
                                    <img id="img1" width="190px" height="190px" src="images/Bishal_Gautam.jpg"/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Name : Bishal Kumar Gautam
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Email : bishalkrgautam@gmail.com
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Computer Science Department, Lamar University
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td width="32%">
                        <table>
                            <tr>
                                <td>
                                    <img id="img2" width="190px" height="190px" src="images/Shreejan_Shrestha.jpg"/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Name : Shreejan Shrestha
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Email : shreejan5755shrestha@gmail.com
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Computer Science Department, Lamar University
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
