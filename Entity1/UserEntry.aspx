<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserEntry.aspx.cs" Inherits="Entity1.UserEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User Entry Form
            <table>
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    Enter the name :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                    Enter the Username :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                    Enter the Password :
                                </td>
                                <td>
                                     <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                    Enter the email :
                                </td>
                                <td>
                                     <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                    Enter DOB :
                                </td>
                                <td>
                                     <asp:TextBox ID="txtdob" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>

                                </td>
                                <td>
                                    <asp:Button ID="Save_button" runat="server" Text="Save" />
                                </td>
                            </tr>
                            </table>
                        </td>
                    </tr
                  <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                        </td>
                    </tr>

             </table>
        </div>
    </form>
</body>
</html>
