<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="seme-polaganja-betonskih-elemenata.aspx.cs" Inherits="ekogradnjav2.seme_polaganja_betonskih_elemenata" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Šeme polaganja betonskih elemenata</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="row">
                <div id="proizvodi" class="col-md-3">
                    <p>Odaberite element:</p>
                    <asp:Repeater ID="repeaterProizvodi" runat="server">
                        <ItemTemplate>
                            <%--<div class="proizvodPrvaStrana">--%>
                                <ul>
                                    <li>
                                        <asp:HyperLink CssClass="zeleniTekst" runat="server" NavigateUrl='<%#Eval("url","/seme-polaganja-betonskih-elemenata/{0}") %>'><%#Eval("nazivProizvoda") %></asp:HyperLink>
                                        <asp:HyperLink runat="server" CssClass="proizvodLink" NavigateUrl='<%# String.Format("/betonska-galanterija/{0}-{1}", Eval("url"), Eval("idProizvoda")) %>' Target="_blank" Visible='<%#int.Parse(Eval("idProizvoda").ToString())>0 %>'><small>stranica proizvoda</small></asp:HyperLink>
                                    </li>
                                </ul>
                            <%--</div>--%>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
    
                <div id="seme" class="col-md-9">
                    <asp:Label ID="lblStatus" runat="server"></asp:Label>
    
                    <asp:Repeater ID="repeaterSeme" runat="server">
                        <HeaderTemplate>
                            <ul>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="sema col-md-6">
                                <span class="semaHeader">
                                    <span class="left"><%#Eval("nazivSeme") %></span>
                                    <span class="right"><%#Eval("dimenzija") %></span>
                                    <asp:Image runat="server" ImageUrl='<%#Eval("idSeme","/images/uputstva/3-{0}.jpg") %>' AlternateText='<%#Eval("nazivSeme") %>' CssClass="img-responsive" />
                                </span>
                            </li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
</asp:Content>
