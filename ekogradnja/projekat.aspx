<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="projekat.aspx.cs" Inherits="ekogradnja.projekat" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" media="all" href="/css/jquery.lightbox-0.5.css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1><asp:Label ID="lblNazivProjekta" runat="server"></asp:Label></h1>
    <h2><asp:Label ID="lblDatumProjekta" runat="server"></asp:Label></h2>
    
    <p><asp:Label ID="lblOpisProjekta" runat="server"></asp:Label></p>
    
    <p><asp:Label ID="lblSadrzaj" runat="server"></asp:Label></p>
    
    <asp:Repeater ID="repeaterSlike" runat="server">
        <HeaderTemplate>
            <div id="thumbnails">
                <ul class="clearfix">
        </HeaderTemplate>
        
        <ItemTemplate>
            <li class="proizvodLi"><a href='<%#Eval("url","{0}.jpg") %>'><img src='<%#Eval("url","{0}-thumb.jpg") %>' alt='<%#Eval("rb") %>' /></a></li>
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
        e.scrollIntoView();
    </script>
</asp:Content>
