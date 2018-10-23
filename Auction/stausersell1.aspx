<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stausersell1.aspx.cs" Inherits="Auction.stausersell1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script language=javascript>
function focus()
{
    document.getElementById("TextBox2").focus()    
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
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td width ="9%">
                  <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" NavigateUrl="~/Logout1.aspx"
            >LogOut</asp:HyperLink>
                </td>
            </tr>
        </table>
            </div >
        <div Style="background:#3E828F">
        <table width="100%">
            <tr>
                <td>
                    <img width="375 "height="331" src="images/record_keeping.jpg" />
                </td>
                <td>
                    <table>
                         <tr>
                <td>

                </td>
                <td>

                </td>
                <td width="20%">
                     <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Style="text-align:right;" NavigateUrl="~/straightmain1.aspx"
            >Back</asp:HyperLink>
                </td>
            </tr>
            <tr>
               
                <td colspan="2">
                    <img src="images/zedge2578nl.jpg" />
                </td>
                  <td>

                </td>
            </tr>
            <tr>
                <td colspan="2">
                     <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="text-align:center" Height="8px"  Text="                 Register"
            Width="162px"></asp:Label>
                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td colspan="2">
                     <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="text-align:center" ForeColor="Red" ></asp:Label>
                </td>
                  <td>

                </td>
            </tr>
            <tr>
                <td style="width: 109px" >
                    <strong>Customer Id</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" TabIndex="1"></asp:TextBox></td>
              <td>

                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Item Name</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server" TabIndex="2"></asp:TextBox></td>
             <td>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="Must Enter Charecters Only"  ValidationExpression="[/a-z A-Z]{1,15}">*</asp:RegularExpressionValidator>
                </td>
                </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Initial Cost</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox3" runat="server" TabIndex="3"></asp:TextBox></td>
                  <td>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3"
            ErrorMessage="Must Enter Digits Only"  ValidationExpression="[/0-9]{1,15}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Increment Cost</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server" TabIndex="4"></asp:TextBox></td>
                  <td>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox4"
            ErrorMessage="Must Enter Digits Only"  ValidationExpression="[/0-9]{1,15}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    <strong>Item Description</strong></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5"  Textmode="MultiLine" runat="server" TabIndex="5"></asp:TextBox></td>
                  <td>
                       
                </td>
            </tr>
                        <tr>
                            <td>
                                 <strong>Image</strong></td>
                            </td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                            </td>
                            <td>

                            </td>

                        </tr>
            <tr>
                <td style="width: 109px">
                    <strong>No. Of Days</strong></td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList1" runat="server" TabIndex="6" Width="156px">
                        <asp:ListItem>----Select----</asp:ListItem>
                    </asp:DropDownList></td>
                  <td>

                </td>
            </tr>
            <tr>
                <td>

                </td>
                <td>
                     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Submit" />&nbsp:&nbsp:&nbsp:&nbsp:
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"  Text="Reset" />
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
