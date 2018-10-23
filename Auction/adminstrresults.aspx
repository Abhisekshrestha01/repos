<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminstrresults.aspx.cs" Inherits="Auction.adminstrresults" %>

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
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Height="24px" NavigateUrl="~/adminresults.aspx"
            Style="z-index: 104; left: 654px; position: absolute; top: 24px">Back</asp:HyperLink>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Height="24px" Style="z-index: 105;
            left: 336px; position: absolute; top: 96px" Text="Item Report"></asp:Label>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"
            CellPadding="4" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="GridView2_PageIndexChanging"
            PageSize="5" Style="z-index: 106; left: 180px; position: absolute; top: 120px">
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
        <asp:Image ID="Image1" runat="server" Height="48px" ImageUrl="~/images/zedge1039nl.jpg"
            Style="z-index: 116; left: 264px; position: absolute; top: 8px" Width="234px" />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Style="z-index: 107; left: 162px;
            position: absolute; top: 336px" Text="Item Id"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Style="z-index: 108; left: 384px;
            position: absolute; top: 336px" Text="Cust Id"></asp:Label>
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Style="z-index: 109; left: 138px;
            position: absolute; top: 368px" Text="Item Name"></asp:Label>
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Style="z-index: 110; left: 384px;
            position: absolute; top: 368px" Text="Amount"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Style="z-index: 111; left: 222px;
            position: absolute; top: 336px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 112; left: 222px; position: absolute;
            top: 368px" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Style="z-index: 113; left: 450px;
            position: absolute; top: 336px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Style="z-index: 114; left: 450px; position: absolute;
            top: 368px" Enabled="False"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 102;
            left: 360px; position: absolute; top: 400px" Text="Submit" Width="60px" />
    
    </div>
    </form>
</body>
</html>
