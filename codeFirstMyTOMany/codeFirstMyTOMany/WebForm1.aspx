<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="codeFirstMyTOMany.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnDataBinding="Page_Load" Text="Assign WCF Course to Mike" />
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" OnDataBinding="Page_Load" Text="Remove John from Sql Server Course" />
        </p>
    </form>
</body>
</html>
