<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleForm._Default" %>

<html>
    <head>
        </head>

     <body>
        <form id="form" runat="server">
            <table>
                <tr>
                    <td>Country Code</td>
                    <td>
                    <asp:TextBox ID="txttcountrycode" runat="server" AutoPostBack="True" OnTextChanged="txttcountrycode_TextChanged"></asp:TextBox></td>
                    </tr>
                <tr>
                     <td>Name</td>
                    <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
                    </tr>
                <tr>
                     <td>Capital</td>
                    <td>
                    <asp:TextBox ID="txtcapital" runat="server"></asp:TextBox></td>
                    </tr>
                <tr>
                     <td colspan="2"></td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </tr>
                </table>
        </form>
        </body>
    </html>
