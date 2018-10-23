<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seauserbuy1.aspx.cs" Inherits="Auction.seauserbuy1" %>

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
                     <p style="height:30px; font-size:60px;  text-shadow: 3px 2px green;">Online Auction system</p>
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
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
                <td width ="9%">
                  <asp:HyperLink ID="HyperLink2" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/Logout1.aspx"
            >LogOut</asp:HyperLink>
                </td>
            </tr>
        </table>
            </div >
       <div Style="background:#3E828F">
           <table width="100%">
               <tr>
                   <td>

                   </td>
                   <td colspan="2" style="text-align:center">
                       <img src="images/seall.jpg"  />
                   </td>
                  
                   <td style="text-align:right">
                       <asp:HyperLink ID="HyperLink1" runat="server" style="text-decoration:none" Font-Bold="True" NavigateUrl="~/seausermain1.aspx"
                >Back</asp:HyperLink>
                   </td>
                   <td>

                   </td>
                   
               </tr>
              
               <tr>
                   <td>

                   </td>
                  
                   <td></td>
                   <td></td>
                   <td>

                   </td>
               </tr>
               <tr>
                   <td>

                   </td>
                   <td colspan2 style="text-align:center">
                       <asp:Label ID="Label8" runat="server" Font-Bold="True"  Text="Item Report" Height="24px"></asp:Label>
                   </td>
                   <td colspan="2">

                   </td>
                  
               </tr>
                <tr>
                   <td colspan="2">

                   </td>
                   <td colspan="2">

                   </td>
                   <td>

                   </td>
                   
               </tr>
               <tr>
                   <td colspan="6" style="text-align:center">
                       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84"
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"
            Width="535px" AllowPaging="True" PageSize="1" Height="120px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="itemid" HeaderText="Item Id" />
                <asp:BoundField DataField="itemname" HeaderText="Item Name" />
                <asp:BoundField DataField="cdate" HeaderText="Date" />
                <asp:BoundField DataField="noofdays" HeaderText="Days" />
                <asp:BoundField DataField="initialcost" HeaderText="Intial Cost" />
                <asp:BoundField DataField="incrementcost" HeaderText="Increment Cost" />
                <asp:BoundField DataField="itemdesc" HeaderText="Item Desc" />
                <asp:BoundField DataField="custid" HeaderText="Cust Id" />
            </Columns>
            <PagerSettings PageButtonCount="1" />
        </asp:GridView>
                   </td>
                  
               </tr>
               <tr>
                   <td colspan="6" style="text-align:center">
                       <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black"
            GridLines="Vertical" AllowPaging="True" PageSize="2" OnPageIndexChanging="GridView2_PageIndexChanging">
            <FooterStyle BackColor="#CCCC99" />
            <Columns>
                <asp:BoundField DataField="itemid" HeaderText="Item Id" />
                <asp:BoundField DataField="itemname" HeaderText="Item Name" />
                <asp:BoundField DataField="custname" HeaderText="Customer Name" />
                <asp:BoundField DataField="buyerdate" HeaderText="Buyer Date" />
                
            </Columns>
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
                   </td>
                  
               </tr>
               <tr>
                   
                   <td style="text-align:right">
                       <asp:Label ID="Label3" runat="server"  Text="Item Id" Font-Bold="True"></asp:Label>
                   </td>
                   <td>
                        <asp:TextBox ID="TextBox1" runat="server"  Enabled="False"></asp:TextBox>
                   </td>
                   <td style="text-align:right">
                       <asp:Label ID="Label4" runat="server"  Text="Cust Id" Font-Bold="True"></asp:Label>
                   </td>
                   <td>
                        <asp:TextBox ID="TextBox3" runat="server"  Enabled="False"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td style="text-align:right">
                        <asp:Label ID="Label5" runat="server"  Text="Item Name" Font-Bold="True"></asp:Label>
                   </td>
                   <td>
                        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                   </td>
                   <td style="text-align:right">
                       <asp:Label ID="Label6" runat="server"  Text="Amount" Font-Bold="True"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>

                   </td>
                   <td>

                   </td>
                   <td>

                   </td>
                   <td>

                   </td>
                   <td>

                   </td>
               </tr>
               <tr>
                   <td>

                   </td>
                   <td>

                   </td>
                   <td >
                       <asp:Button ID="Button1" runat="server"  Text="Post" OnClick="Button1_Click" Width="60px" />
        &nbsp;
                   </td>
                   <td>

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
