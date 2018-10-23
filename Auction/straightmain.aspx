<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="straightmain.aspx.cs" Inherits="Auction.straightmain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
<!--

function IMG1_onclick() {

}

// -->
</script>
</head>
<body bgcolor="#eeedbb">
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="stauserview.aspx"
            Style="z-index: 101; left: 348px; position: absolute; top: 112px">View Items</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" NavigateUrl="~/stauserbuy.aspx"
            Style="z-index: 102; left: 366px; position: absolute; top: 176px" Width="30px">Buy</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" NavigateUrl="~/stausersell.aspx"
            Style="z-index: 103; left: 330px; position: absolute; top: 144px" Width="114px">Item Registation</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/usermain.aspx"
            Style="z-index: 104; left: 366px; position: absolute; top: 208px" Width="36px">Back</asp:HyperLink>
        &nbsp;
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/zedge1039nl.jpg" Style="z-index: 107;
            left: 282px; position: absolute; top: 8px" />
    
    </div>
    </form>
</body>
</html>

