<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="kontakt.aspx.cs" Inherits="ekogradnja.kontakt" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript" src="/js/jquery-1.8.2.js" ></script>
    <script type="text/javascript" src="/js/jquery-ui-1.9.0.custom.min.js" ></script>
    <script type="text/javascript" src="/js/jquery-ui-tabs-rotate.js" ></script>
    <script type="text/javascript" src="/js/jquery-1.6.1.min.js"></script>
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
    <script type="text/javascript" src="/js/markers.js"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Kontakt</h1>
    
    <div class="column500">
        <h2 class="kontakt">Ekogradnja doo</h2>
        <h3 class="kontakt">Proizvodnja, transport i ugradnja betonske galanterije</h3>
        <p>Njegoševa bb</p>
        <p>23270 Melenci</p>
    
        <p><b>Telefon:</b> +381 (0)23 741 260</p>
        <p><b>Fax:</b> +381 (0)23 741 261</p>
        <p><b>Mobilni:</b> +381 (0)63 699 489</p>
        <p><a href="mailto:info@ekogradnja.rs" class="tekst">info@ekogradnja.rs</a></p>
        <p><a href="http://www.ekogradnja.rs" class="tekst">www.ekogradnja.rs</a></p>
        
        <h2 class="kontakt topMargin40">Betonska baza Zrenjanin</h2>
        <p>Industrijska zona Bagljaš</p>
        <p><b>Mobilni:</b> +381 (0)63 699 854</p>
        <p><b>Mobilni:</b> +381 (0)63 5333503</p>
        
        <h2 class="kontakt topMargin40">Šljunkara i separacija šljunka</h2>
        <p>Na obali Tise kod Žabaljskog mosta, između Zrenjanina i Novog Sada</p>
        
        
        
        
    </div>
    
    <div id="mapa">
        <div id="map"></div>
    </div>
    
    <div id="kontaktForma">
        <p class="justify">Kontaktirajte nas i saznajte više o proizvodima koji Vas interesuju. Postavite pitanje ili pošaljite sugestiju. Odgovorićemo Vam u najkraćem roku.</p>
        
        <p>Vaš email:</p>
        <p><asp:TextBox class="kontaktTextBox" ID="txtEmail" runat="server" Width="100"></asp:TextBox></p>
        
        <p>Naslov poruke:</p>
        <p><asp:TextBox class="kontaktTextBox" ID="txtNaslov" runat="server" Width="100"></asp:TextBox></p>
        
        <p>Poruka:</p>
        <p><asp:TextBox class="kontaktTextBox" ID="txtPoruka" runat="server" TextMode="MultiLine" Width="300" Height="200"></asp:TextBox></p>
        
        <asp:Button ID="btnPosalji" runat="server" OnClick="btnPosalji_Click" Text="Pošalji" />
    </div>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        
        e.scrollIntoView();
    </script>
</asp:Content>
