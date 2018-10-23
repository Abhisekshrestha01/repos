<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dauusermain.aspx.cs" Inherits="Auction.dauusermain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/dauuserview.aspx"
            Style="z-index: 100; left: 336px; position: absolute; top: 104px">View Items</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" NavigateUrl="~/dauuserbuy.aspx"
            Style="z-index: 101; left: 354px; position: absolute; top: 168px" Width="30px">Buy</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" NavigateUrl="~/dauusersell.aspx"
            Style="z-index: 102; left: 318px; position: absolute; top: 136px">Item Registation</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/usermain.aspx"
            Style="z-index: 103; left: 348px; position: absolute; top: 200px" Width="42px">Back</asp:HyperLink>
        &nbsp;
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/dau.jpg" Style="z-index: 105;
            left: 270px; position: absolute; top: 8px" />
    
    </div>
    </form>
</body>
</html>
