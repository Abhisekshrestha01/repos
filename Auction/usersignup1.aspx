<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usersignup1.aspx.cs" Inherits="Auction.usersignup1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script language=javascript>
function focus()
{
    document.getElementById("txtname").focus()    
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
                     <asp:LinkButton ID="LinkButton5" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton11_Click">Home</asp:LinkButton>
                </td>
                <td width ="9%">
                    <asp:LinkButton ID="LinkButton6" runat="server" style="text-decoration:none" Font-Bold="True" OnClick="LinkButton12_Click">Admin</asp:LinkButton>
                </td>
            </tr>
        </table>
         <div Style="background:#3E828F" >
             <table width="100%">
                 <tr>
                     <td width="30%">

                     </td>
                     <td width="45%">
                         <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"  Visible="False" Width="198px"></asp:Label>
        &nbsp;
        
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
            ShowSummary="False"  />
                     </td>
                     <td>

                     </td>
                 </tr>
                 <tr>
                     <td>
                         <img src="images/cart-central.jpg" width="100%" height="100%"  />
                     </td>
                     <td>
                         <table id="Table1" cellpadding="1" cellspacing="1"  width="100%">
            <tr>
                <td width="40%">
                    <asp:Label ID="Label2" runat="server">NAME</asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtname" runat="server" TabIndex="1" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtname"
            ErrorMessage="Must Enter In Characters Only" ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 28px; width: 130px;">
                    <asp:Label ID="Label3" runat="server">USER NAME</asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtuname" runat="server" TabIndex="2" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtuname"
            ErrorMessage="Wrong" 
            ValidationExpression="[/a-z A-Z 0-9 . _]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label4" runat="server">PASSWORD</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TabIndex="3" TextMode="Password" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd"
            ControlToValidate="txtrepwd" ErrorMessage="Password Does not Match"  Width="6px">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    Re-Write Password&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtrepwd" runat="server" Width="154px" TextMode="Password" TabIndex="4"></asp:TextBox></td>
                <td>

                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label5" runat="server">Mobile Number</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtmobile" runat="server" TabIndex="5" Width="154px"></asp:TextBox></td>
                <td>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtmobile"
            ErrorMessage="Must Enter In Numerics Only"  ValidationExpression="[/0-9]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label6" runat="server">E-Mail Id</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server" TabIndex="6" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtemail"
            ErrorMessage="Must Enter Correct Email Id" ValidationExpression="[/a-z A-Z][\w\. -]*[/a-z A-Z 0-9]@[/a-z A-Z 0-9][\w\. -]*[/a-z A-Z 0-9]\.[/a-z A-Z][/a-z A-Z\.]*[/a-z A-Z]$">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label7" runat="server">CREDIT CARD NO</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtccno" runat="server" TabIndex="7" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtccno"
            ErrorMessage="Must Enter Correct Format"  ValidationExpression="[/a-z A-Z 0-9]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label8" runat="server">STREET NAME</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtsname" runat="server" TabIndex="8" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtsname"
            ErrorMessage="Must Enter In Characters Only"  ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label9" runat="server">CITY</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtcity" runat="server" TabIndex="9" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtcity"
            ErrorMessage="Must Enter In Characters Only"  ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label10" runat="server">COUNTRY</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtcountry" runat="server" Width="154px" TabIndex="10"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="txtcountry"
            ErrorMessage="Must Enter In Characters Only"  ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 130px; height: 28px">
                    <asp:Label ID="Label11" runat="server">PINCODE</asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtpincode" runat="server" TabIndex="11" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server"
            ControlToValidate="txtpincode" ErrorMessage="Must Enter Correct PinCode"  ValidationExpression="\d{6}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 130px; width: 130px;">
                    <asp:Label ID="Label12" runat="server">What is your mother's name(security question):</asp:Label></td>
                <td style="height: 28px">
                    <asp:TextBox ID="txtsecurityquestion" runat="server" TabIndex="1" Width="154px"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="txtsecurityquestion"
            ErrorMessage="Must Enter In Characters Only"  ValidationExpression="[/a-z A-Z]{1,25}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
                             <tr>
                     <td>

                     </td>
                     <td>
                         <asp:Button ID="btnreg" runat="server" TabIndex="12" Text="Submit" Font-Bold="True" Width="84px" Height="24px" OnClick="btnreg_Click" />
                    &nbsp;
                         <asp:Button ID="btnreset" runat="server" TabIndex="13" Text="Reset" Font-Bold="True" Height="24px" Width="72px" OnClick="btnreset_Click"  />
                     </td>
                     <td>

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
         <p>
             &nbsp;</p>
    </form>
</body>
</html>
