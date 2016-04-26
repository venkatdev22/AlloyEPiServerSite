<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StringList.ascx.cs" Inherits="$rootnamespace$.Views.Properties.StringList" %>
<asp:Repeater ID="list" runat="server">
    <HeaderTemplate><ul></HeaderTemplate>
    <ItemTemplate><li><%#Server.HtmlEncode(Container.DataItem.ToString())%></li></ItemTemplate>
    <FooterTemplate></ul></FooterTemplate>
</asp:Repeater>
