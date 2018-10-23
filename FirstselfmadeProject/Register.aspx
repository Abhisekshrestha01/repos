<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FirstselfmadeProject.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    Register Yourself<br />
    <asp:Tab<asp:LayoutEditorPart></asp:LayoutEditorPart> ID="Table1" runat="server" Width="329px">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                Enter the Name
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is Mandatory" controltovalidate="txtname"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                Enter the Username

            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>

            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Username is Mandatory" controltovalidate="txtusername"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                Enter the Password

            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>

            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="password is Mandatory" controltovalidate="txtpassword"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                Enter the Email
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>

            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email is Mandatory" controltovalidate="txtemail"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                DoB
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="txtdob" runat="server">

                </asp:TextBox>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="DOB is Mandatory" controltovalidate="txtdob"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Text="Save" /> &nbsp;
                <asp:Button ID="btnClear" runat="server" Text="Clear" />

                
            </asp:TableCell>
        </asp:TableRow>


    </asp:Table>
    


    <asp:GridView ID="grdUsers" runat="server" Width="313px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="grdUsers_SelectedIndexChanged">
        <AlternatingRowStyle BorderColor="Maroon" />
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
        </Columns>
        <HeaderStyle BorderStyle="Dashed" />
    </asp:GridView>
    


   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" SelectCommand="SELECT [Name], [Username], [Password], [Email], [DOB] FROM [Userss]"></asp:SqlDataSource>
    


&nbsp;
    


</asp:Content>
