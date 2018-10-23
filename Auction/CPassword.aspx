<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CPassword.aspx.cs" Inherits="Auction.CPassword" %>

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
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </td>
                    <td>

                     </td>
                        
                </tr>
                <tr>
                     <td>
                         <asp:Label ID="Label2" runat="server" Text="Confirm password"></asp:Label>
                     &nbsp;</td>
                     <td>
                         <asp:TextBox ID="txtcpassword" runat="server"></asp:TextBox>
                     </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Mismatch" ControlToCompare="txtpassword" ControlToValidate="txtcpassword" SetFocusOnError="True"></asp:CompareValidator>
                     </td>

                </tr>
                <tr>
                     <td>

                     </td>
                     <td>
                         <asp:Button ID="btn_save" OnClick="Button1_Click" runat="server" Text="Save" />
                         <asp:Button ID="btn_reset" OnClick="Button2_Click" runat="server" Text="Reset" />
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
