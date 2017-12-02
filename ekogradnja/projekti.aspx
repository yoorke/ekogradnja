<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="projekti.aspx.cs" Inherits="ekogradnja.projekti" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" media="all" href="/css/jquery.lightbox-0.5.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <a id="heading" name="heading"></a>
    <h1>Projekti</h1>
    
    <asp:Repeater ID="repeaterProjekti" runat="server" OnItemDataBound="repeaterProjekti_ItemDataBound">
        <ItemTemplate>
            <div class="projekatSkraceno">
                <h2><asp:HyperLink runat="server" NavigateUrl='<%#Eval("url","/projekti/{0}") %>' CssClass="tekst"><asp:Label ID="lblNazivProjekta" runat="server" Text='<%#Eval("nazivProjekta") %>'></asp:Label></asp:HyperLink></h2>
                <h3>Godina: <asp:Label ID="lblDatumProjekta" runat="server" Text='<%# DateTime.Parse(Eval("datumProjekta").ToString()).Year %>'></asp:Label></h3>
                <p><asp:Label ID="lblOpisProjekta" runat="server" Text='<%#Eval("opisProjekta") %>'></asp:Label></p>
                
                <div id="thumbnails">
                    <a href='<%#Eval("idProjekta","/images/projekti/{0}-1.jpg") %>'><asp:Image ID="imgProjekat1" runat="server" ImageUrl='<%#Eval("idProjekta", "/images/projekti/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProjekta") + "1" %>' /></a>
                    <a href='<%#Eval("idProjekta","/images/projekti/{0}-2.jpg") %>'><asp:Image ID="imgProjekat2" runat="server" ImageUrl='<%#Eval("idProjekta", "/images/projekti/{0}-2-thumb.jpg") %>' AlternateText='<%#Eval("nazivProjekta") + "2" %>' /></a>
                    <a href='<%#Eval("idProjekta","/images/projekti/{0}-2.jpg") %>'><asp:Image ID="imgProjekat3" runat="server" ImageUrl='<%#Eval("idProjekta", "/images/projekti/{0}-3-thumb.jpg") %>' AlternateText='<%#Eval("nazivProjekta") + "3" %>' /></a>
                </div>
                
                <a href='<%#Eval("url", "/projekti/{0}")%>' class="dalje">pročitaj više</a>
            </div>
            
       </ItemTemplate>
        
    </asp:Repeater>
    
    <script type="text/javascript">
        $(function() {
            $('#thumbnails a').lightBox();
        });
    </script>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        e.scrollIntoView();
    </script>
    
</asp:Content>
