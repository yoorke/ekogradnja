<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="dokumenti.aspx.cs" Inherits="ekogradnja.dokumenti" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Dokumenti</h1>
    
    <ul>
        <li class="linkovi"><img src="/images/adobe-pdf-logo-sm.png" width="16px" height="16px" alt="pdf" /><a href="/id-obrazac.pdf" target="_blank" class="tekst">Podaci za identifikaciju</a></li>
        <li class="linkovi"><img src="/images/adobe-pdf-logo-sm.png" width="16px" height="16px" alt="pdf" /><a href="/pdv.pdf" target="_blank" class="tekst">PDV obrazac</a></li>
        <li class="linkovi"><img src="/images/adobe-pdf-logo-sm.png" width="16px" height="16px" alt="pdf" /><a href="/EkoGradnjaKatalog_m.pdf" target="_blank" class="tekst">Katalog proizvoda</a></li>
        <li class="linkovi marginLeft20"><a href="/uslovi-prodaje" class="tekst">Uslovi prodaje</a></li>
    </ul>
    <script type="text/javascript">
        
            var e = document.getElementById("heading")
            e.scrollIntoView();
        
    </script>
</asp:Content>
