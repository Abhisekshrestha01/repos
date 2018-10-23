<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Dummy._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First Website</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="Scripts/Register.js?2"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td colspan="3" style="text-align: center">User Registration</td>
                </tr>
                <tr>
                    <td style="width: 20%">Name</td>
                    <td style="width: 50%">
                        <asp:TextBox ID="txtFirstName" runat="server" Width="100%"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Enter name first" ValidationGroup="UserReg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%">Password</td>
                    <td style="width: 50%">
                        <asp:TextBox ID="txtPassword" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter Password" ValidationGroup="UserReg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%">Roles</td>
                    <td style="width: 50%">
                        <asp:DropDownList ID="ddlRole" runat="server" Width="100%" AutoPostBack="True" OnSelectedIndexChanged="ddlRole_SelectedIndexChanged">
                            <asp:ListItem Value="Select Role" Text="Select Role" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="A" Text="Admin"></asp:ListItem>
                            <asp:ListItem Value="E" Text="Enginner"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlRole" ErrorMessage="Select Role" InitialValue="Select Role" ValidationGroup="UserReg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="rdlGender" runat="server" Width="100%">
                            <asp:ListItem Value="M" Text="Male" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="F" Text="Female"></asp:ListItem>
                        </asp:RadioButtonList></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Hobbies</td>
                    <td>
                        <asp:CheckBoxList ID="chkHobbies" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Net Surfing</asp:ListItem>
                            <asp:ListItem>Playing Cards</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Driving</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:Button ID="btnClear" runat="server" Text="Cancel" OnClick="btnClear_Click" ValidationGroup="UserReg" />
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" ValidationGroup="UserReg" />

                    </td>
                </tr>
            </table>
            <table style="width: 100%;">
                <tr>
                    <td colspan="3" style="text-align: center">Signup</td>
                </tr>
                <tr>
                    <td style="width: 20%">Name</td>
                    <td style="width: 50%">
                        <asp:TextBox ID="txtSignupName" runat="server" Width="100%"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSignupName" ErrorMessage="Enter name first" ValidationGroup="Signup"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%">Password</td>
                    <td style="width: 50%">
                        <asp:TextBox ID="txtSignUpPassword" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtSignUpPassword" ErrorMessage="Enter Password" ValidationGroup="Signup"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:Button ID="btnSignupCancel" runat="server" Text="Cancel" ValidationGroup="Signup" OnClick="btnSignupCancel_Click" />
                        <asp:Button ID="btnSignupLogin" runat="server" Text="Login" ValidationGroup="Signup" OnClick="btnSignupLogin_Click" />

                    </td>
                </tr>
            </table>

            <table style="width: 100%;">
                <tr>
                    <td colspan="3" style="text-align: center">API Signup</td>
                </tr>
                <tr>
                    <td style="width: 20%">Name</td>
                    <td style="width: 50%">
                        <input id="txtAPIName" style="width: 100%" />
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 20%">Password</td>
                    <td style="width: 50%">
                        <input id="txtAPIPassword" style="width: 100%" />

                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <input type="button" id="btnAPIClear" value="Cancel" />
                        <input type="button" id="btnAPISave" value="Save" onclick="SaveData()" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
