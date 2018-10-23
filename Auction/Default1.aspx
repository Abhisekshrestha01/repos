<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="Auction.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language=javascript>
function focus()
{
    document.getElementById("TextBox1").focus()    
        }
        function displayNextImage() {
            x = (x === images.length - 1) ? 0 : x + 1;
            document.getElementById("img").src = images[x];
        }

        function displayPreviousImage() {
            x = (x <= 0) ? images.length - 1 : x - 1;
            document.getElementById("img").src = images[x];
        }

        function startTimer() {
            setInterval(displayNextImage, 3000);
        }

        var images = [], x = -1;
        images[0] = "images/bike.jpg";
        images[1] = "images/194-laptop.jpg";
        images[2] = "images/background.jpg";
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
                    <asp:LinkButton ID="LinkButton5" runat="server" style="text-decoration:none" Font-Bold="True" >Home</asp:LinkButton>
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
                <td width="30%">
                     <img id="img" height="350px" width="350px" src="images/OnlineAuction.jpg"/>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button type="button" onclick="displayPreviousImage()">Previous</button>
       <button type="button" onclick="displayNextImage()">Next</button>
                    
           
                </td>
                 <td width="30%">
                      <table>
                           <tr >
                <td >
                  <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Visible="False" Width="264px"></asp:Label>
                    </td>
                               <td>

                               </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    User Name</td>
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
                <td>

                </td>
                <td >
                    
                    <asp:Button ID="Button3" runat="server" Text="Submit" OnClick="Button1_Click" />
               
                    &nbsp; &nbsp;
                    <asp:Button ID="Button4" runat="server" Text="Reset" OnClick="Button2_Click" /></td>
                
            </tr>
                          <tr>
                              <td colspan="2">
                                  <table>
                        <tr>
                            <td >
                                 <asp:Label ID="Label5" runat="server"  Text="New User :"></asp:Label>
                            </td>
                            <td>
  <asp:LinkButton ID="LinkButton7" runat="server"  OnClick="LinkButton3_Click" Font-Bold="True">Sign Up</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td >
                                 <asp:Label ID="Label6" runat="server"  Text="Forget password :"></asp:Label>
                            </td>
                            <td>
                                   <asp:LinkButton ID="LinkButton8" runat="server"  OnClick="LinkButton4_Click" Font-Bold="True">Change password</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                              </td>
                          </tr>
        </table>
                </td>
                 <td width="40%">
                      <asp:Image ID="Image4" runat="server" height="250px" width="250px" ImageUrl="~/images/add4.GIF"   />
                </td>
            </tr>
            <tr>
                <td width="30%">

                </td>
                <td width="40%">
                    
                </td>
                <td width="30%">

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
