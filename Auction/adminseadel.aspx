<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminseadel.aspx.cs" Inherits="Auction.adminseadel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        <div>
            <div>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="z-index: 100; left: 294px;
                    position: absolute; top: 64px" Text="Item Id"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="False" Style="z-index: 101;
                    left: 354px; position: absolute; top: 64px">
                    <asp:ListItem>----Select----</asp:ListItem>
                </asp:DropDownList>
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Height="24px" NavigateUrl="~/admindel.aspx"
                    Style="z-index: 102; left: 654px; position: absolute; top: 24px">Back</asp:HyperLink>
                <asp:Image ID="Image1" runat="server" Height="48px" ImageUrl="~/images/seall.jpg"
                    Style="z-index: 103; left: 264px; position: absolute; top: 8px" Width="234px" />
                <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click"
                    Style="z-index: 104; left: 342px; position: absolute; top: 104px" Text="Delete" />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                    CellPadding="3" CellSpacing="2" OnPageIndexChanging="GridView1_PageIndexChanging"
                    PageSize="5" Style="z-index: 105; left: 72px; position: absolute; top: 144px"
                    Width="535px">
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
                        <asp:BoundField DataField="custid" HeaderText="Cust Id" />
                    </Columns>
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="z-index: 107;
                    left: 468px; position: absolute; top: 64px" Visible="False" Width="162px"></asp:Label>
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
