<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="rigole-i-kanalete.aspx.cs" Inherits="ekogradnjav2.rigole_i_kanalete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Rigole i kanalete</h1>
        </div>
    </div>
    <div class="row margin-top-2">
        <div class="col-md-12">
            <asp:Repeater ID="rptRigoleIKanalete" runat="server">
        <HeaderTemplate>
            <ul class="list-style-type-none">
        </HeaderTemplate>
        <ItemTemplate>
            <li class="proizvodLi">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("url","{0}") %>'><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("idProizvoda","/images/proizvodi/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProizvoda","Rigole i kanalete - {0}") %>' />
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("nazivProizvoda") %>'></asp:Label>
                </asp:HyperLink>
            </li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
        </div>
        <div class="col-md-3">

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
</asp:Content>
