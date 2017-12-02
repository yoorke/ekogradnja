<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="projekat.aspx.cs" Inherits="ekogradnjav2.projekat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1><asp:Label ID="lblNazivProjekta" runat="server"></asp:Label></h1>
            <h2><asp:Label ID="lblDatumProjekta" runat="server"></asp:Label></h2>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <p><asp:Label ID="lblOpisProjekta" runat="server"></asp:Label></p>
            <p><asp:Label ID="lblSadrzaj" runat="server"></asp:Label></p>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
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
