<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminmain.aspx.cs" Inherits="Auction.adminmain" %>

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
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/adminviewreport.aspx"
            Style="z-index: 100; left: 294px; position: absolute; top: 224px">View Reports</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" NavigateUrl="~/Logout.aspx"
            Style="z-index: 101; left: 306px; position: absolute; top: 344px">Sign Out</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Style="z-index: 102;
            left: 294px; position: absolute; top: 264px" NavigateUrl="~/admindel.aspx">Delete Items</asp:HyperLink>
        &nbsp;
        <img id="IMG1" src="images/admin.gif" style="z-index: 104; left: 216px; width: 252px;
            position: absolute; top: 8px; height: 192px;" language="javascript" onclick="return IMG1_onclick()" />
        <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" NavigateUrl="~/adminresults.aspx"
            Style="z-index: 105; left: 306px; position: absolute; top: 304px">Results</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
