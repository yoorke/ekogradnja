<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="seme-polaganja-betonskih-elemenata.aspx.cs" Inherits="ekogradnja.seme_polaganja_betonskih_elemenata" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1><asp:Label ID="lblNaslov" runat="server"></asp:Label></h1>
    
    <div id="proizvodi">
        <p>Odaberite element:</p>
        <asp:Repeater ID="repeaterProizvodi" runat="server">
            <ItemTemplate>
                <%--<div class="proizvodPrvaStrana">--%>
                    <ul>
                        <li>
                            <asp:HyperLink CssClass="zeleniTekst" runat="server" NavigateUrl='<%#Eval("url","/seme-polaganja-betonskih-elemenata/{0}") %>'><%#Eval("nazivProizvoda") %></asp:HyperLink>
                            <asp:HyperLink runat="server" CssClass="proizvodLink" NavigateUrl='<%# String.Format("/betonska-galanterija/{0}-{1}", Eval("url"), Eval("idProizvoda")) %>' Target="_blank" Visible='<%#int.Parse(Eval("idProizvoda").ToString())>0 %>'>stranica proizvoda</asp:HyperLink>
                        </li>
                    </ul>
                <%--</div>--%>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    
    <div id="seme">
    <asp:Label ID="lblStatus" runat="server"></asp:Label>
    
    <asp:Repeater ID="repeaterSeme" runat="server">
        <ItemTemplate>
            <div class="sema">
                <div class="semaHeader">
                    <p class="left"><%#Eval("nazivSeme") %></p>
                    <p class="right"><%#Eval("dimenzija") %></p>
                    <asp:Image runat="server" ImageUrl='<%#Eval("idSeme","/images/uputstva/3-{0}.jpg") %>' AlternateText='<%#Eval("nazivSeme") %>' />
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    </div>
    <%--<div class="sema">
        <div class="semaHeader">
            <p class="left">Kombinacija 1</p>
            <p class="right">10x20 i 20x20</p>
            <img src="/images/uputstva/3-1.jpg" />
        </div>
    </div>
    
    <div class="sema">
        <div class="semaHeader">
            <p class="left">Kombinacija 2</p>
            <p class="right">10x20 i 20x20</p>
            <img src="/images/uputstva/3-2.jpg" />
        </div>
    </div>--%>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        e.scrollIntoView();
    </script>
</asp:Content>
