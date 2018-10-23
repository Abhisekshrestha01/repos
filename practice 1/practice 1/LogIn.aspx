<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LogIn.aspx.cs" Inherits="practice_1.LogIn" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/style1.css" rel="stylesheet" />
       <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
 <script>
     $(document).ready(function () {
         $('#divContainer img').on({
             mouseover: function () {
                 $(this).css({
                         'cursor': 'pointer',
                         'border-Color': 'red'
                 });
             },
             mouseout: function () {
                 $(this).css({
                         'cursor': 'default',
                         'border-Color': 'grey'
                 });
             },
             click: function () {
                 var imageUrl = $(this).attr('src');
                 $('#mainImage').fadeOut(300, function () {
                     $(this).attr('src', imageUrl);
                 }).fadeIn(300);
             }
         });
     });
 </script>
    <style>
        .imgstyle
        {
            height:63px;
            width:63px;
            border:3px solid grey;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                 <img id="mainImage" height="400" width="400" style="border:3px solid grey;" src="Image/image1.jpg" />
   <div id="divContainer">
       <img src="image/image1.jpg" class="imgstyle" />
        <img src="image/image3.jpg" class="imgstyle" />
       <img src="image/image2.jpg" class="imgstyle" />
        <img src="image/image4.jpg" class="imgstyle" />
       <img src="image/image3.jpg" class="imgstyle" />
        <img src="image/image4.jpg" class="imgstyle" />
   </div>
            </td>
            
            <td>
                <div style="padding-top:10px; padding-bottom:20px; padding-right10px; padding-left:30px;">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="3">
                        <h3 align="center">LOG-IN</h3>
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
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="UserName is Required" ControlToValidate="txtusername"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Labelpassword" runat="server" Text="Password"></asp:Label>
                    </td>
                     <td>
                         <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is Required" ControlToValidate="txtpassword"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LabelloginIssue" runat="server"></asp:Label>
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Login" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Clear" />
                    </td>
                     <td>

                    </td>
                    

                </tr>
               
            </table>
        </div>
    </form>
        </div></td>
        </tr>
    </table>
    
     
</asp:Content>


