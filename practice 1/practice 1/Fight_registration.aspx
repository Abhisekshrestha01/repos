<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Fight_registration.aspx.cs" Inherits="practice_1.Fight_registration" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.js"></script> 
    <script src="Scripts/jquery-3.3.1.min.js"></script>
     <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>--%>
    <script src="Scripts/JavaScript.js"></script>

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
                        <asp:Label ID="LabelFlightno"  runat="server" Text="Flight ID" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox class="input-text" ClientIDMode="Static" ID="txtflightno" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <div id="Labelerrorflightno"></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Labelname" runat="server" Text="flightname"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList4" ClientIDMode="Static" runat="server">
                            
                        </asp:DropDownList>
                    </td>
                    <td>
                        <div id="Labelerrorflightname"></div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelDepartureCity" runat="server" Text="DepartureCity"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDCity" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <div id="Labelerrordepartmentcity"></div>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelDepartureDate" runat="server" Text="Departure Date"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDdate" placeholder="DD/mm/yyyy" ClientIDMode="Static"  runat="server"></asp:TextBox>
                        <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/Image/img_calender.png" OnClick="ImageButton1_Click" style="width: 20px" />
                        <div id="Labelerrordepartmentdate"></div>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelArrivalCity" runat="server" Text="Arrival City"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtACity" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <div id="LabelerrorarrivalCity"></div>
                       
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelArrivalTime" runat="server" Text="Arrival Time"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtATime" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <div id="LabelerrorArrivalTime"></div>
                       
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelNoSeat" runat="server" Text="No. Of Seats"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNSeats" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <div id="Labelerrorseats"></div>
                        
                    </td>
                </tr>
               
              
                <tr>
                   
                    <td colspan="2" align="center">

                        <asp:Button ID="Button1" ClientIDMode="Static" runat="server" class="btn btn-primary" Text="Submit" OnClick="Button1_Click"  />
                        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Clear" OnClientClick="alert('Do you want to clear')" CausesValidation="False" />

                    </td>
                    <td>

                        &nbsp;</td>
                </tr>
            </table>
        </div>
        
    </form>

</asp:Content>