    <%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="projekti.aspx.cs" Inherits="ekogradnjav2.projekti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Projekti</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <asp:Repeater ID="repeaterProjekti" runat="server" OnItemDataBound="repeaterProjekti_ItemDataBound">
                <ItemTemplate>
                    <div class="col-md-4">
                        <div class="thumbnail projekat">
                            <h2><asp:HyperLink runat="server" NavigateUrl='<%#Eval("url","/projekti/{0}") %>' CssClass="tekst"><asp:Label ID="lblNazivProjekta" runat="server" Text='<%#Eval("nazivProjekta") %>'></asp:Label></asp:HyperLink></h2>
                            <h3>Godina: <asp:Label ID="lblDatumProjekta" runat="server" Text='<%# DateTime.Parse(Eval("datumProjekta").ToString()).Year %>'></asp:Label></h3>
                            <p class="description"><asp:Label ID="lblOpisProjekta" runat="server" Text='<%#Eval("opisProjekta") %>'></asp:Label></p>
                
                            <%--<div id="thumbnails">
                                <a href='<%#Eval("idProjekta","/images/projekti/{0}-1.jpg") %>'><asp:Image ID="imgProjekat1" runat="server" ImageUrl='<%#Eval("idProjekta", "/images/projekti/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProjekta") + "1" %>' /></a>
                                <a href='<%#Eval("idProjekta","/images/projekti/{0}-2.jpg") %>'><asp:Image ID="imgProjekat2" runat="server" ImageUrl='<%#Eval("idProjekta", "/images/projekti/{0}-2-thumb.jpg") %>' AlternateText='<%#Eval("nazivProjekta") + "2" %>' /></a>
                                <a href='<%#Eval("idProjekta","/images/projekti/{0}-2.jpg") %>'><asp:Image ID="imgProjekat3" runat="server" ImageUrl='<%#Eval("idProjekta", "/images/projekti/{0}-3-thumb.jpg") %>' AlternateText='<%#Eval("nazivProjekta") + "3" %>' /></a>
                            </div>--%>
                            <asp:HyperLink ID="lnkProjekat" runat="server" NavigateUrl='<%#Eval("url", "/projekti/{0}") %>'>
                                <asp:Image ID="imgProjekat" runat="server" ImageUrl='<%#Eval("idProjekta", "/images/projekti/{0}-1.jpg") %>' CssClass="img-responsive" />
                            </asp:HyperLink>
                            <a href='<%#Eval("url", "/projekti/{0}")%>' class="dalje">pročitaj više</a>
                        </div>
                    </div>
            
            </ItemTemplate>
        
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
    <!--<script type="text/javascript">
        $(function() {
            $('#thumbnails a').lightBox();
        });
    </script>-->
</asp:Content>
