<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="page.aspx.cs" Inherits="ekogradnja.Page" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1><asp:Label ID="lblNaslov" runat="server"></asp:Label></h1>
    
    <div id="txtContent" runat="server"></div>
</asp:Content>
