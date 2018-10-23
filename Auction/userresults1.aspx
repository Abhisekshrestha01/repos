<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userresults1.aspx.cs" Inherits="Auction.userresults1" %>

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
                    <td style="text-align:center">
                        <h1>Results</h1>
                    </td>
                    <td style="text-align:right;">
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" style="text-decoration:none;" Height="24px" NavigateUrl="~/usermain1.aspx"
            >Back</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                         <asp:DropDownList ID="DropDownList1" AutoPostBack="true" DataTextField="itemname" DataValueField="itemid" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" >
        </asp:DropDownList>
                    </td>
                    <td>

                    </td>
                </tr>
                </table>
            <table>
                <tr>
                    <td>
                        <table>
                             <tr>
                    <td>
                         <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" OnClick="LinkButton1_Click"
            >straight Auction</asp:LinkButton>
                    </td>
                   
                </tr>
                <tr>
                    <td>
                         <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" OnClick="LinkButton2_Click"
            >dutch Auction</asp:LinkButton>
                    </td>
                   
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" OnClick="LinkButton3_Click"
            >Sealed Auction</asp:LinkButton>
                    </td>
                   
                    
                </tr>
                            <tr>
                                <td rowspan="8">

                                </td>
                               
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td style="text-align:center">
                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large"  Width="294px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
            CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
             Width="432px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <Columns>
                <asp:BoundField DataField="itemid" HeaderText="Item Id" />
                <asp:BoundField DataField="itemname" HeaderText="Item Name" />
                <asp:BoundField DataField="custname" HeaderText="Customer Name" />
                <asp:BoundField DataField="amount" HeaderText="Amount" />

            <asp:BoundField DataField="qty" HeaderText="Quantity" />
            </Columns>
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
               
            </table>
            
        
        
        
        
        
       
        
        
    
    </div>
       
    </form>
</body>
</html>
