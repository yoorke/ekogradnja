<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="galerija.aspx.cs" Inherits="ekogradnja.galerija" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <!--<link rel="stylesheet" type="text/css" media="all" href="/css/gallery-styles.css" />-->
  <link rel="stylesheet" type="text/css" media="all" href="/css/jquery.lightbox-0.5.css" />
  <!--<script type="text/javascript" src="/js/jquery-1.10.1.min.js"></script>-->
  <!--<script type="text/javascript" src="/js/jquery.lightbox-0.5.min.js"></script>-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Galerija</h1>
    
    <%--<h2>Proizvodi</h2>--%>
    Odaberite godinu:
    <ul class="galerijaUl">
        <!--<li><a href="/galerija/2009">2009</a></li>
        <li><a href="/galerija/2010">2010</a></li>-->
        <li><a href="/galerija/2011">2011</a></li>
        <li><a href="/galerija/2012">2012</a></li>
        <li><a href="/galerija/2013">2013</a></li>
        <li><a href="/galerija/2014">2014</a></li>
    </ul>
    
    <%--<asp:Repeater ID="galleryProizvodi" runat="server">
        <HeaderTemplate>
            <div id="thumbnails">
                <ul class="clearfix">
        </HeaderTemplate>
        
        <ItemTemplate>
            <li class="proizvodLi"><a href='<%#Eval("url","{0}.jpg") %>'><img src='<%#Eval("url","{0}-thumb.jpg") %>' /></a></li>
        </ItemTemplate>
        
        <FooterTemplate>
                </ul>
            </div>
        </FooterTemplate>
    </asp:Repeater>--%>
    
    
    <%--<h2>Projekti</h2>--%>
    <h2><asp:Label ID="lblGodina" runat="server"></asp:Label></h2>
    <asp:Repeater ID="galleryProjekti" runat="server" OnItemDataBound="galleryProjekti_ItemDataBound">
        <HeaderTemplate>
            <div id="thumbnails">
                <ul class="galerijaUl list-style-type-none">
        </HeaderTemplate>
        
        <ItemTemplate>
            <li><a href='<%#Eval("url", "{0}.jpg") %>'><img src='<%#Eval("url","{0}-thumb.jpg") %>' alt='<%#Eval("alt") %>' title='<%#Eval("alt") %>' hspace="5px" vspace="5px" /></a></li>
        </ItemTemplate>
        
        <FooterTemplate>
                </ul>
            </div>
        </FooterTemplate>
    </asp:Repeater>
    
    <script type="text/javascript">
        $(function() {
            $('#thumbnails a').lightBox();
        });
    </script>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        e.scrollIntoView(true);
    </script>
</asp:Content>
