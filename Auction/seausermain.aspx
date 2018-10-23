<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seausermain.aspx.cs" Inherits="Auction.seausermain" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/seall.jpg" Style="z-index: 105;
            left: 276px; position: absolute; top: 16px" />
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/seauserview.aspx"
            Style="z-index: 101; left: 336px; position: absolute; top: 96px">View Items</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" NavigateUrl="~/seauserbuy.aspx"
            Style="z-index: 102; left: 354px; position: absolute; top: 168px">Buy</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" NavigateUrl="~/seausersell.aspx"
            Style="z-index: 103; left: 312px; position: absolute; top: 136px">Item Registration</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/usermain.aspx"
            Style="z-index: 104; left: 348px; position: absolute; top: 200px" Width="42px">Back</asp:HyperLink>
        &nbsp;
    
    </div>
    </form>
</body>
</html>
