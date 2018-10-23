<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td style="height: 24px">

                <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>

            </td>
            <td style="height: 24px">

                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>

                Gender</td>
            <td>

                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="Label3" runat="server" Text="Salary"></asp:Label>

            </td>
            <td>

                <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td colspan="2">

                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

            </td>
           
        </tr>
        <tr>
            <td colspan="2">

                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

                <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>

            </td>
        </tr>
    </table>
</asp:Content>
