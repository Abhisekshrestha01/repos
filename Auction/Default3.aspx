<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default3.aspx.cs" Inherits="Auction.Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language=javascript>
function focus()
{
    document.getElementById("TextBox1").focus()    
}
function IMG1_onclick() {

}

</script>
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
                    <asp:LinkButton ID="LinkButton5" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton3_Click" >Home</asp:LinkButton>
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
            <table width="100%">
                <tr>
                    <td>
 <img  src="images/login_splash.jpg" height="350px" width="350px"  />
                    </td>
                    <td>
                        <table >
                            <tr>
                                <td colspan="2">
                                     <img src="images/ADMINI.jpg"  />
                                </td>
                            </tr>
                            <tr>
                                <td >

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
                                     <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Style="z-index: 101;
            left: 450px; position: absolute; top: 88px" Visible="False" Width="264px"></asp:Label>
                                </td>
                            </tr>
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
