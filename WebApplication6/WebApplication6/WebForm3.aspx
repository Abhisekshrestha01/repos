<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication6.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Employee Details Form"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Sex"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex" Text="Male" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sex" Text="Female" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="alert(&quot;You are about to submit this page&quot;);" OnCommand="Button1_Command" Text="Register Employee" />
        </p>
    </form>
</body>
</html>
