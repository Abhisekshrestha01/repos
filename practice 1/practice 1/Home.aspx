<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.cs" Inherits="practice_1.Home" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-top:10px; padding-bottom:20px;">
    <form id="form1" runat="server">
        <div align="center">
            
            <div style="float:right;  margin-right: 10px;"><asp:Button  ID="Button2" class="btn btn-secondary" runat="server" Text="Edit" OnClick="Button2_Click" />
                <asp:Button ID="Button1" runat="server" class="btn btn-secondary" Text="Logout" OnClick="Button1_Click" /></div>
            <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Label"></asp:Label>
            <div><asp:Image ID="Image1" runat="server" Width="100px" Height="100px"  /></div>
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
                        <asp:Label ID="Label8" Font-Bold="true" runat="server" ></asp:Label> 

           <div><asp:Button ID="Button3" class="btn btn-primary" runat="server" OnClick="Button3_Click" Text="Flight Registration" /></div>
          
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" PageSize="3" OnPageIndexChanging="GridView2_PageIndexChanging" >
               <Columns>
                   <asp:BoundField DataField="flightno" HeaderText="flightno" />
                   <asp:BoundField DataField="fligHtName" HeaderText="fligHtName" />
                   
                   <asp:TemplateField>
                       <ItemTemplate>
                           <asp:LinkButton ID="Detail" Text="Show More" runat="server" CommandArgument='<%# Eval("flightno") %>' OnClick="Detail_Click"></asp:LinkButton>
                       </ItemTemplate>
                   </asp:TemplateField>
               </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerSettings FirstPageText="3" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
                <asp:Label ID="Label10" Font-Bold="true" runat="server"></asp:Label>
            <asp:GridView ID="GridView3" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
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
                <table align="center" align="center" width="20%" >
                    <tr>
                        <td>
                            <div><asp:Label ID="Label3" runat="server"></asp:Label></div>
            <div><asp:Label ID="Label4" runat="server"></asp:Label></div>
            <div><asp:Label ID="Label5" runat="server"></asp:Label></div>
            <div><asp:Label ID="Label6" runat="server"></asp:Label></div>
            <div><asp:Label ID="Label7" runat="server"></asp:Label></div>
            <div><asp:Label ID="Label9" runat="server"></asp:Label></div>
                        </td>
                    </tr>
                </table>
                
                           </div>
            </form>
        </div>

</asp:Content>

