<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stauserbuy.aspx.cs" Inherits="Auction.stauserbuy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="z-index: 100; left: 294px;
            position: absolute; top: 64px" Text="Item Id"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Bold="False"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="z-index: 101;
            left: 354px; position: absolute; top: 64px">
            <asp:ListItem>----Select----</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Style="z-index: 102; left: 378px; position: absolute;
            top: 456px" Text="Post" OnClick="Button1_Click" Width="60px" />
        &nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84"
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"
            Style="z-index: 103; left: 144px;
            position: absolute; top: 120px" Width="535px" AllowPaging="True" PageSize="1" Height="120px">
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
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/straightmain.aspx"
            Style="z-index: 104; left: 654px; position: absolute; top: 24px" Height="24px">Back</asp:HyperLink>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="z-index: 105; left: 336px;
            position: absolute; top: 96px" Text="Item Report" Height="24px"></asp:Label>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White"
            BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black"
            GridLines="Vertical" Style="z-index: 106; left: 186px; position: absolute; top: 248px" AllowPaging="True" PageSize="2" OnPageIndexChanging="GridView2_PageIndexChanging">
            <FooterStyle BackColor="#CCCC99" />
            <Columns>
                <asp:BoundField DataField="itemid" HeaderText="Item Id" />
                <asp:BoundField DataField="itemname" HeaderText="Item Name" />
                <asp:BoundField DataField="custid" HeaderText="Customer Id" />
                <asp:BoundField DataField="buyerdate" HeaderText="Buyer Date" />
                <asp:BoundField DataField="amount" HeaderText="Amount" />
            </Columns>
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:Label ID="Label3" runat="server" Style="z-index: 107; left: 192px; position: absolute;
            top: 384px" Text="Item Id" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label4" runat="server" Style="z-index: 108; left: 414px; position: absolute;
            top: 384px" Text="Cust Id" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label5" runat="server" Style="z-index: 109; left: 168px; position: absolute;
            top: 416px" Text="Item Name" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label6" runat="server" Style="z-index: 110; left: 414px; position: absolute;
            top: 416px" Text="Amount" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 111; left: 252px; position: absolute;
            top: 384px" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 112; left: 252px; position: absolute;
            top: 416px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 113; left: 480px; position: absolute;
            top: 384px" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Style="z-index: 114; left: 480px; position: absolute;
            top: 416px"></asp:TextBox>
        <asp:Image ID="Image1" runat="server" Height="48px" ImageUrl="~/images/zedge1039nl.jpg"
            Style="z-index: 116; left: 264px; position: absolute; top: 8px" Width="234px" />
    
    </div>
    </form>
</body>
</html>
