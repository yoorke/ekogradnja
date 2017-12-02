<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="galerija.aspx.cs" Inherits="ekogradnjav2.galerija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Galerija</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            Odaberite godinu:
            <ul class="galerijaUl">
                <!--<li><a href="/galerija/2009">2009</a></li>
                <li><a href="/galerija/2010">2010</a></li>-->
                <li><a href="/galerija/2011">2011</a></li>
                <li><a href="/galerija/2012">2012</a></li>
                <li><a href="/galerija/2013">2013</a></li>
                <li><a href="/galerija/2014">2014</a></li>
            </ul>

            <h2><asp:Label ID="lblGodina" runat="server"></asp:Label></h2>
            <asp:Repeater ID="galleryProjekti" runat="server" OnItemDataBound="galleryProjekti_ItemDataBound">
                <HeaderTemplate>
                    <div id="thumbnails">
                        <ul class="clearfix galerijaUl list-style-type-none">
                </HeaderTemplate>
        
                <ItemTemplate>
                    <li><a href='<%#Eval("url", "{0}.jpg") %>'><img src='<%#Eval("url","{0}-thumb.jpg") %>' alt='<%#Eval("alt") %>' title='<%#Eval("alt") %>' hspace="5px" vspace="5px" /></a></li>
                </ItemTemplate>
        
                <FooterTemplate>
                        </ul>
                    </div>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
    <script type="text/javascript">
        $(function() {
            $('#thumbnails a').lightBox();
        });
    </script>
</asp:Content>
