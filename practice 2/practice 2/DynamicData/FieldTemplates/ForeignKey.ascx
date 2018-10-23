<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="practice_2.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

