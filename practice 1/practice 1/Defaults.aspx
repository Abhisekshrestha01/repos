 <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Defaults.aspx.cs" Inherits="practice_1.Defaults" %>


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
            <table runat="server">
                <tr>
                    <td colspan="2" align="center">
                        
                        <h2><asp:Label ID="Label1" runat="server" Text="Registration"></asp:Label></h2>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Labelname" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox class="input-text" ID="txtname" runat="server"></asp:TextBox>
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
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Male">Male</asp:ListItem>
                            <asp:ListItem Text="Female">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" runat="server" ErrorMessage="Please select Gender" ControlToValidate="RadioButtonList1" ValidationGroup="Registration"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Labelemail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Red" runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Registration"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Education"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                            <asp:ListItem Value="HS">HSchool</asp:ListItem>
                            <asp:ListItem Value="BA">Bachelor</asp:ListItem>
                            <asp:ListItem Value="MA">Master</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                    </td>
                </tr>
                
                 <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Location"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataTextField="ContinentName" DataValueField="ContinentId" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        

                        <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="CountryName" DataValueField="CountryId" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList3" runat="server" DataTextField="CityName" DataValueField="CityId">
                        </asp:DropDownList>
                        

                    </td>
                    <td class="auto-style1">

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" runat="server" ControlToValidate="DropDownList3" ErrorMessage="Please select the dropdown" ValidationGroup="Registration"></asp:RequiredFieldValidator>

                    </td>
                </tr>
                 <tr>
                     <td colspan="2">
                         <asp:FileUpload ID="FileUpload1" runat="server" />
                     </td>
                     <td>

                         <asp:Label ID="Label7" runat="server"></asp:Label>

                     </td>
                 </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangeValidatorAge" runat="server" ForeColor="Red" ErrorMessage="Age must be between 1 and 100" ControlToValidate="txtage" MaximumValue="100" MinimumValue="1" Type="Integer" Display="Dynamic" ValidationGroup="Registration"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ForeColor="Red" ErrorMessage="Age is Required" Display="Dynamic" ControlToValidate="txtage" ValidationGroup="Registration"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Labelusername" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" runat="server" ErrorMessage="Username is Required" ControlToValidate="txtusername"></asp:RequiredFieldValidator>
                        <asp:Label ID="Label8" ForeColor="Red" runat="server"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Labelpassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtpassword" runat="server"  TextMode="Password"></asp:TextBox>  
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator  ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ErrorMessage="Password is required" ControlToValidate="txtpassword" ValidationGroup="Registration"></asp:RequiredFieldValidator>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:Label ID="Labelrepassword" runat="server" Text="Re-passsword"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtrepassword" runat="server" AutoPostBack="False"  TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ControlToCompare="txtpassword" ControlToValidate="txtrepassword" ErrorMessage="password does not matche" ValidationGroup="Registration"></asp:CompareValidator>
                        </td>
                </tr>
                <tr>
                   
                    <td colspan="2" align="center">

                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="Button1_Click" OnClientClick="return confirm(&quot;Are you going to submit&quot;)" OnCommand="Button1_Command" ValidationGroup="Registration" />
                        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Clear" OnClick="Button2_Click" OnClientClick="alert('Do you want to clear')" CausesValidation="False" />

                    </td>
                    <td>

                        &nbsp;</td>
                </tr>
            </table>
        </div>
        
    </form>
</asp:Content>

