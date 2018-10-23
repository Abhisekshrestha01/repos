<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userresults.aspx.cs" Inherits="Auction.userresults" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Style="z-index: 100;
            left: 312px; position: absolute; top: 32px" Width="294px"></asp:Label>
        &nbsp; &nbsp;
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
            CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
            Style="z-index: 101; left: 222px; position: absolute; top: 72px" Width="432px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <Columns>
                <asp:BoundField DataField="itemid" HeaderText="Item Id" />
                <asp:BoundField DataField="itemname" HeaderText="Item Name" />
                <asp:BoundField DataField="custid" HeaderText="Customer Id" />
                <asp:BoundField DataField="amount" HeaderText="Amount" />
            </Columns>
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        &nbsp; &nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" OnClick="LinkButton1_Click"
            Style="z-index: 102; left: 30px; position: absolute; top: 104px">Stright Auction</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" OnClick="LinkButton2_Click"
            Style="z-index: 103; left: 30px; position: absolute; top: 152px">Dautch Auction</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" OnClick="LinkButton3_Click"
            Style="z-index: 105; left: 30px; position: absolute; top: 200px">Sealed Auction</asp:LinkButton>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Height="24px" NavigateUrl="~/usermain.aspx"
            Style="z-index: 104; left: 654px; position: absolute; top: 24px">Back</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>

