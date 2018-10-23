<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admindau1.aspx.cs" Inherits="Auction.admindau1" %>

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
                    <asp:Label ID="Label5" runat="server" Text="ADMIN"></asp:Label>
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
                         <asp:Image ID="Image1" runat="server" Height="48px" ImageUrl="~/images/dau.jpg"  Width="234px" />
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/adminviewreport1.aspx"
                >Back</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Label ID="Label2" runat="server" Font-Bold="True"  Text="Item Report"></asp:Label>
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <asp:TextBox ID="txtSearch" runat="server" ></asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="Button" />
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:GridView ID="GridView123" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                CellPadding="3" CellSpacing="2"  Width="535px" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
                <PagerSettings PageButtonCount="1" />
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <Columns>
                    <asp:BoundField DataField="itemid" HeaderText="Item Id" />
                    <asp:BoundField DataField="itemname" HeaderText="Item Name" />
                    <asp:BoundField DataField="cdate" HeaderText="Date" />
                    <asp:BoundField DataField="noofdays" HeaderText="Days" />
                    <asp:BoundField DataField="initialcost" HeaderText="Intial Cost" />
                    <asp:BoundField DataField="incrementcost" HeaderText="Increment Cost" />
                    <asp:BoundField DataField="itemdesc" HeaderText="Item Desc" />
                    <asp:BoundField DataField="qty" HeaderText="Quantity" />
                    <asp:BoundField DataField="custid" HeaderText="Cust Id" />
                    <asp:ImageField DataImageUrlField="Image_path" ControlStyle-Height="100" ControlStyle-Width="100" HeaderText="Image" />
               
                    <asp:TemplateField>
            <ItemTemplate >
                <asp:LinkButton ID="lnkDetails" runat="server" Text="Result" HeaderText="Results" PostBackUrl='<%# "~/admindauresult1.aspx?ID=" + Eval("itemid") %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>

                    </Columns>
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
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
            
            
            
            
        </div>
    </form>
</body>
</html>
