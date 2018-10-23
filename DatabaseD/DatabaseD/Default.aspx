<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatabaseD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td colspan ="2">
                <asp:Label ID="Label1" runat="server" Text="Data Form"></asp:Label>
                </td>
            
            </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:TextBox ID="txtname" runat="server" ToolTip="Enter the name"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td>
                sex</td>
            <td>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="m" Text="Male" />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="m" Text="Female" />
                </td>
            </tr>
        <tr>
            <td>
                city</td>
            <td>
                <asp:DropDownList ID="DropDownList1" DataTextField="CityName" DataValueField="Id" runat="server">
                </asp:DropDownList>
                </td>
            </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" OnClientClick="confirm(&quot;Are yu sure you wan tto submit&quot;);" Text="Submit" OnClick="Button1_Click" />
                </td>
            
            </tr>
        <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="CityName" HeaderText="CityName" SortExpression="CityName" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DropDownConnectionString %>" SelectCommand="SELECT [Id], [CityName], [Country] FROM [Dropdown]"></asp:SqlDataSource>
            </td>
        </tr>
        </table>

</asp:Content>
