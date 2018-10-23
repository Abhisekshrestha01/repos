<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seauserbuy.aspx.cs" Inherits="Auction.seauserbuy" %>

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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 102;
                left: 372px; position: absolute; top: 368px" Text="Post" Width="60px" />
            &nbsp;
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                CellPadding="3" CellSpacing="2" PageSize="2" Style="z-index: 103; left: 144px;
                position: absolute; top: 120px" Width="535px" OnPageIndexChanging="GridView1_PageIndexChanging">
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
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/seausermain.aspx"
                Style="z-index: 104; left: 654px; position: absolute; top: 24px">Back</asp:HyperLink>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="z-index: 105; left: 336px;
                position: absolute; top: 96px" Text="Item Report"></asp:Label>
            &nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Style="z-index: 107; left: 186px;
                position: absolute; top: 296px" Text="Item Id"></asp:Label>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Style="z-index: 108; left: 408px;
                position: absolute; top: 296px" Text="Cust Id"></asp:Label>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Style="z-index: 109; left: 162px;
                position: absolute; top: 328px" Text="Item Name"></asp:Label>
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Style="z-index: 110; left: 408px;
                position: absolute; top: 328px" Text="Amount"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 111; left: 246px; position: absolute;
                top: 296px" Enabled="False"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 112; left: 246px; position: absolute;
                top: 328px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 113; left: 474px; position: absolute;
                top: 296px" Enabled="False"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" Style="z-index: 114; left: 474px; position: absolute;
                top: 328px"></asp:TextBox>
            &nbsp;
            <img src="images/seall.jpg" style="z-index: 115; left: 252px; width: 258px; position: absolute;
                top: 8px; height: 48px" />
        </div>
    </form>
</body>
</html>
