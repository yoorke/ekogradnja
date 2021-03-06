﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="ostalo.aspx.cs" Inherits="ekogradnjav2.ostalo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Ostalo</h1>
        </div>
    </div>
    <div class="row margin-top-2">
        <div class="col-lg-12">
            <asp:Repeater ID="repeaterOstalo" runat="server">
        <HeaderTemplate>
            <ul class="list-style-type-none">
        </HeaderTemplate>
        
        <ItemTemplate>
            <li class="proizvodLi">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("url","{0}") %>'><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("idProizvoda","/images/proizvodi/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProizvoda") %>' />
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("nazivProizvoda") %>'></asp:Label></asp:HyperLink>
            </li>
        </ItemTemplate>
        
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
</asp:Content>
