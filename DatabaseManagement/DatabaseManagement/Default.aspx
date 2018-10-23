<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatabaseManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <table>
        <tr>
            <td>


                <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>


            </td>
            <td>


                <asp:Button ID="Btnsearch" runat="server" Text="Search" OnClick="Btnsearch_Click" />


            </td>
            </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>

    

</asp:Content>
