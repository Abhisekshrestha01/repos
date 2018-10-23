<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admindauresult1.aspx.cs" Inherits="Auction.admindauresult1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 1024px;
margin:0px auto;
text-align:left;" >
    <form id="form1" runat="server">
        <div Style="background:#006699;">
         <table >
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
                    <asp:Label ID="Label7" runat="server" Text="ADMIN"></asp:Label>
                </td>
                <td width ="9%">
                  <asp:HyperLink ID="HyperLink5" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/Logout1.aspx"
            >LogOut</asp:HyperLink>
                </td>
            </tr>
        </table>
            </div>
        <div Style="background:#3E828F">
            <table width="100%" style="text-align:center">
               <tr>
                   <td>
                       <table width="100%">
                           <tr>
                               <td>
                                   <asp:Image ID="Image1" runat="server" Height="48px" ImageUrl="~/images/dau.jpg"
            Width="234px" />
                               </td>
                               <td>
                                   <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Height="24px" NavigateUrl="~/admindau1.aspx"
            >Back</asp:HyperLink>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                  
                               </td>
                               
                               <td>

                               </td>
                           </tr>
                          <tr>
                              <td>
                                  <asp:Label ID="Label2" runat="server" Font-Bold="True" Height="24px"  Text="Item Report"></asp:Label>
                              </td>
                              <td>

                              </td>
                          </tr>
                           <tr>
                               <td>
                                   <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"
            CellPadding="4" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="GridView2_PageIndexChanging"
            PageSize="5" >
            <FooterStyle BackColor="#CCCC99" />
            <Columns>
                <asp:BoundField DataField="itemid" HeaderText="Item Id" />
                <asp:BoundField DataField="itemname" HeaderText="Item Name" />
                <asp:BoundField DataField="custname" HeaderText="Customer Name" />
                <asp:BoundField DataField="buyerdate" HeaderText="Buyer Date" />
                <asp:BoundField DataField="amount" HeaderText="Amount" />
<asp:BoundField DataField="qty" HeaderText="Quantity" />

            </Columns>
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
                               </td>
                               <td>

                               </td>
                           </tr>
                       </table>
                   </td>
               </tr>
                <tr>
                    <td>
                        <table style="text-align:center">
                            <tr>
                                <td>
                                   <!-- <asp:Label ID="Label3" runat="server" Font-Bold="True"  Text="Item Id"></asp:Label>-->
                                </td>
                                <td>
                                   <asp:TextBox ID="TextBox1" type="hidden" runat="server" Enabled="False" ></asp:TextBox>
                                </td>
                                <td>
                                    <!-- <asp:Label ID="Label4" runat="server" Font-Bold="True"  Text="Cust Id"></asp:Label> -->
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3" type="hidden" runat="server" Enabled="False" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                   <!-- <asp:Label ID="Label5" runat="server" Font-Bold="True"  Text="Item Name"></asp:Label> -->
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" type="hidden" runat="server"  Enabled="False"></asp:TextBox>
                                </td>
                                <td>
                                    <!-- <asp:Label ID="Label6" runat="server" Font-Bold="True"  Text="Amount"></asp:Label> -->
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox4" type="hidden" runat="server"  Enabled="False"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Submit" Width="60px" />
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
