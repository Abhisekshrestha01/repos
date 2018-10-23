<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CodeFirstBridge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Assign WCF Course to Mike" OnClick="Button1_Click" />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Remove John from SQL Server Course" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
