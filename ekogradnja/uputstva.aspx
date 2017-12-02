<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="uputstva.aspx.cs" Inherits="ekogradnja.uputstva" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a id="heading" name="heading"></a>
    <h1>Uputstva</h1>
    
    <ul>
        <li class="linkovi"><a href="/kako-postaviti-betonske-elemente" class="tekst">Kako postaviti betonske elemente</a></li>
        <li class="linkovi"><a href="/slojevi-tla-za-preopterecenje" class="tekst">Slojevi tla za preopterećenje</a></li>
        <li class="linkovi"><a href="/seme-polaganja-betonskih-elemenata" class="tekst">Šeme polaganja betonskih elemenata</a></li>
    </ul>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        e.scrollIntoView();
    </script>
</asp:Content>
