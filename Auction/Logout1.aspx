<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout1.aspx.cs" Inherits="Auction.Logout1" %>

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
            </div>
        <div Style="background:#3E828F">
            <table width="100%" style="text-align:center">
                <tr>
                    <td>
                        <img id="IMG1" src="images/auct.jpg" language="javascript" onclick="return IMG1_onclick()" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>
           
            YOU HAVE SUCCESSFULLY
            LOGOUT........</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                       <strong> <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Do U Want To Login Click Here</asp:LinkButton></strong>
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
