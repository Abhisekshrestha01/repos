<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usermain.aspx.cs" Inherits="Auction.usermain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="straightmain.aspx"
            Style="z-index: 100; left: 510px; position: absolute; top: 112px" Height="24px" Width="110px">Straight Auction</asp:HyperLink>
        &nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" NavigateUrl="~/dauusermain.aspx"
            Style="z-index: 101; left: 510px; position: absolute; top: 152px" Width="108px" Height="24px">Dautch Auction</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" NavigateUrl="seausermain.aspx"
            Style="z-index: 102; left: 510px; position: absolute; top: 192px" Width="108px" Height="24px">Sealed Auction</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/Logout.aspx"
            Style="z-index: 103; left: 534px; position: absolute; top: 240px">LogOut</asp:HyperLink>
        <asp:HyperLink ID="HyperLink6" runat="server" Font-Bold="True" NavigateUrl="~/userresults.aspx"
            Style="z-index: 103; left: 534px; position: absolute; top: 344px">Results</asp:HyperLink>
        <img src="images/Image1.jpg" style="z-index: 108; left: 35px; width: 375px; position: absolute;
            top: 33px; height: 331px" />
        <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True" NavigateUrl="~/Default.aspx"
            Style="z-index: 104; left: 671px; position: absolute; top: 22px">Home</asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Style="z-index: 105;
            left: 468px; position: absolute; top: 64px" Width="234px"></asp:Label>
        &nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Style="z-index: 109; left: 462px;
            position: absolute; top: 320px" Text="To view the Results Click Here" Width="216px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
