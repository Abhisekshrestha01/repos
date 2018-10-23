<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="edit.aspx.cs" Inherits="practice_1.edit" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
        .auto-style2 {
            height: 33px;
        }
    </style>
    </asp:Content>
    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" class="form-group" runat="server">
        <div class="form-group" align="center">
            <div style="float:right"><asp:Image ID="Image1" runat="server" Width="100px" Height="100px"  /></div>
            <table runat="server">
                <tr>
                    <td colspan="2" align="center">
                        
                        <h2><asp:Label ID="Label1" runat="server" Text="Edit Detail"></asp:Label></h2>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Labelname" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox class="input-text" ID="txtname" runat="server" ValidationGroup="Editbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ErrorMessage="Please Enter the name" ControlToValidate="txtname" ValidationGroup="Registration"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Labelgender" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server"  RepeatDirection="Horizontal" ValidationGroup="Editbox">
                            <asp:ListItem Text="Male" selected ="true" >Male</asp:ListItem>
                            <asp:ListItem Text="Female">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Please select Gender" ControlToValidate="RadioButtonList1" ValidationGroup="Registration"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Labelemail" runat="server" Text="Email" value="<%email %>"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server" ValidationGroup="Editbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Red" runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Registration"></asp:RegularExpressionValidator>
                    </td>
                </tr>
               
                
                 
                   
                <tr>
                    <td>
                        <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtage" runat="server" value="<%age %>" ValidationGroup="Editbox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangeValidatorAge" runat="server" ForeColor="Red" ErrorMessage="Age must be between 1 and 100" ControlToValidate="txtage" MaximumValue="100" MinimumValue="1" Type="Integer" Display="Dynamic" ValidationGroup="Registration"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ForeColor="Red" ErrorMessage="Age is Required" Display="Dynamic" ControlToValidate="txtage" ValidationGroup="Registration"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                   
                    <td colspan="2" align="center">

                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="Button1_Click" OnClientClick="return confirm(&quot;Do you want to edit&quot;)" ValidationGroup="Editbox" />
                        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Clear" OnClick="Button2_Click" OnClientClick="alert('Do you want to clear')" CausesValidation="False" />

                    </td>
                    <td>

                        &nbsp;</td>
                </tr>
            </table>
                        

        </div>
        
    </form>
</asp:Content>


