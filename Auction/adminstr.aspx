<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminstr.aspx.cs" Inherits="Auction.adminstr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
            CellPadding="3" CellSpacing="2" OnPageIndexChanged="GridView1_PageIndexChanged"
            OnPageIndexChanging="GridView1_PageIndexChanging" Style="z-index: 103; left: 144px;
            position: absolute; top: 120px" Width="535px">
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
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/adminviewreport.aspx"
            Style="z-index: 104; left: 654px; position: absolute; top: 24px">Back</asp:HyperLink>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="z-index: 105; left: 336px;
            position: absolute; top: 96px" Text="Item Report"></asp:Label>
        <asp:Image ID="Image1" runat="server" Height="48px" ImageUrl="~/images/zedge1039nl.jpg"
            Style="z-index: 116; left: 264px; position: absolute; top: 8px" Width="234px" />
    
    </div>
    </form>
</body>
</html>

