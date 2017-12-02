<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="ivicnjaci.aspx.cs" Inherits="ekogradnja.ivicnjaci" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Ivičnjaci</h1>
    
    <p class="justify">Tehnologijom za proizvodnju vibroptesovanih ivičnjaka, postižu se odlične karakteristike, koje daju glatku površinu elementa, ektremnu snagu otpornosti na mraz I na hemijske agense. Vibropresovani elementi se proizvode od betona u dva sloja. Integracija pritiska i vibracija u vibropresovanom ivičnjaku obezbeđuje visoku snagu I savršenu estetiku. Pravilno sabijanje i premošcavanje dva sloja elementa daje odlične mehaničke i fizičke osobine:</p>
    <ul>
        <li>• Zatezna čvrstoća</li>
        <li>• Čvrstoća na pritisak</li>
        <li>• Otpornost na mraz i razne hemijske agense</li>
        <li>• Minimalna apsorpcija</li>
        <li>• Optimalna hrapavost</li>
        <li>• Visoka etetska vrednost</li>
    </ul>

    <p class="justify">Tehnologija dvoslojnih vibropresovanih ivičnjaka omogućava optimalno korišćenje dve vrste specijalnih betona, 
    koja ne samo da ispunjava naše standarde nego ih i prevazilazi. Ivičnjaci se obično proizvode u prirodno sivoj boji 
    betona, ili u raličitim kataloškim bojama. Baštenski i putni  ivičnjaci su dostupni u duzinama od 500mm odnosno 800 mm. 
    Ivičnjaci iz Ekogradnje u čitavom procesu proizvodnje prolaze kroz intezivne testove  koji se vrše  u nezavisnim 
    akreditovanim labaratorijama. Dugogodišnje iskustvo u proizvodnji sa visoko kvalitetnim mašinama, upotreba kvalitetnih 
    sirovina, kontinualna kontrola proizvoda daje jake garancije i stabilan kvalitet proizvoda.</p>

    <asp:Repeater ID="repeaterIvicnjaci" runat="server">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        
        <ItemTemplate>
            <li class="proizvodLi">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("url","{0}") %>'><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("idProizvoda","/images/proizvodi/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProizvoda","Ivičnjaci - {0}") %>' />
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("nazivProizvoda") %>'></asp:Label></asp:HyperLink>
            </li>
        </ItemTemplate>
        
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        e.scrollIntoView();
    </script>
    
</asp:Content>
