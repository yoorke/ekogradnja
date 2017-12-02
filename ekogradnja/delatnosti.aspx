<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="delatnosti.aspx.cs" Inherits="ekogradnja.delatnosti" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" media="all" href="/css/jquery.lightbox-0.5.css" />
    <meta name="description" content="Delatnosti kojima se Ekogradnja bavi uključuju proizvodnju betonske galanterije, proizvodnju transportnog betona, postavljanje behaton ploča i betonske galanterije, uređenje i nivelaciju terena i druge radove u niskogradnji" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Delatnosti</h1>
    
    <div class="delatnost">
        <a name="proizvodnja-betonske-galanterije"></a>
        <h2>Proizvodnja betonske galanterije</h2>
    
        <p class="justify"><a href="/betonska-galanterija/behaton-ploce-1">Behaton ploče</a> iz našeg proizvodnog programa su namenjene popločavanju pešačkih i saobraćajnih 
           površina. Širok spektar upotrebe u različitim okruženjima (dvorišta, parkinzi, saobraćajnice, staze) omogućava 
           raznovrsnost njihovih oblika i boja kao i mogućnost kombinovanja. Osim betonskih ploča, bavimo se proizvodnjom 
           ivičnjaka, rigola, kanaleta, kao i betoskih cevi i šahtova</p>
           
            <div id="thumbnails">
                <ul class="clearfix">
                    <li class="inline"><a href="/images/proizvodnja-betonske-galanterije.JPG"><img src="/images/proizvodnja-betonske-galanterije.JPG" width="300px" height="200px" alt="Proizvodnja betonske galanterije" /></a></li>
                    <li class="inline"><a href="/images/proizvodnja-betonske-galanterije-1.JPG"><img src="/images/proizvodnja-betonske-galanterije-1.JPG" width="300px" height="200px" alt="Proizvodnja betonske galanterije" /></a></li>
                </ul>
            </div>
    </div>
        <%--<p class="justify"><a href='/betonska-galanterija' class="tekst">Behaton ploče</a> iz našeg proizvodnog programa su namenjene popločavanju pešačkih i saobraćajnih površina. 
           Širok spektar upotrebe u različitim okruženjima (dvorišta, parkinzi, saobraćajnice, staze) omogućava 
           raznovrsnost njihovih oblika i boja kao i mogućnost kombinovanja.</p>

        <p class="justify">Behaton ploče se proizvode od <strong>prirodnih materijala</strong> tehnologijom <strong>vibro-presovanja</strong> i tehnologijom livenja.
           Sve ploče su dvoslojne - donji nosivi sloj je od betona do 8mm, a gornji zaštitni sloj je od betona 0,2 mm 
           sa kvarcnim peskom. Po želji naručioca ploče se proizvode u najrazličitijim bojama.</p>

        <p class="justify">Materijali koji se koriste za izradu vibro-presovane betonske galanterije, kao i sama galanterija imaju 
           <strong>sertifikate o kvalitetu</strong> izdate od akreditovane ustanove.</p>

        <p class="justify">Prednosti behaton ploča su višestruke: lako se postavljaju (na pesak), lako se podižu u slučaju eventualnih 
           radova, ne koriste se drugi materijali (cement, armatura), podnose opterećenja intenzivnog saobraćaja, 
           ne klizaju se, otporne su na mraz, ulepšavaju prostor.</p>--%>
    
    <div class="delatnost">
        <a name="proizvodnja-transportnog-betona"></a>
        <h2>Proizvodnja transportnog betona</h2>
    
            <p class="justify">Posedujemo dve betonske baze jedna je locirana u Melencima , i druga u industrijskoj zoni u 
            Zrenjaninu</p>
         
            <div id="thumbnails">
                <ul class="clearfix">
                    <li class="inline"><a href="/images/proizvodnja-i-transport-betona.JPG"><img src="/images/proizvodnja-i-transport-betona.JPG" width="300px" height="200px" alt="Betonska baza" /></a></li>
                    <li class="inline"><a href="/images/proizvodnja-i-transport-betona-1.JPG"><img src="/images/proizvodnja-i-transport-betona-1.JPG" width="300px" height="200px" alt="Proizvodnja betona" /></a></li>
                </ul>
            </div>
    </div>
    
    <div class="delatnost">
        <a name="postavljanje-behaton-ploca-i-betonske-galanterije"></a>
        <h2>Postavljanje behaton ploča i betonske galanterije</h2>
    
        <p class="justify">Sinonim za „Eko gradnja“d.o.o. je postavljane betonskih ploča,po tome smo prepoznatljivi po 
           celoj Vojvodini.</p>
        
        <div id="thumbnails">   
            <ul class="clearfix">
                <li class="inline"><a href="/images/postavljanje-behaton-ploca.JPG"><img src="/images/postavljanje-behaton-ploca.JPG" width="300px" height="200px" alt="Postavljanje behaton ploča" /></a></li>
                <li class="inline"><a href="/images/postavljanje-behaton-ploca-1.JPG"><img src="/images/postavljanje-behaton-ploca-1.JPG" width="300px" height="200px" alt="Popločavanje betonskom galanterijom" /></a></li>
            </ul>
        </div>
    </div>
    
    <div class="delatnost">
        <a name="uredjenje-i-nivelacija-terena"></a>
        <h2>Uređenje i nivelacija terena</h2>
    
        <p class="justify">Specilizovni smo za izradu ataskih puteva,otrsišta i tucaničkih platoa</p>
        
        <div id="thumbnails">
            <ul class="clearfix">
                <li class="inline"><a href="/images/uredjenje-i-nivelacija-terena.JPG"><img src="/images/uredjenje-i-nivelacija-terena.JPG" width="300px" height="200px" alt="Uređenje i nivelacija terena" /></a></li>
                <li class="inline"><a href="images/uredjenje-i-nivelacija-terena-1.JPG"><img src="images/uredjenje-i-nivelacija-terena-1.JPG" width="300px" height="200px" alt="Uređenje i nivelacija terena" /></a></li>
            </ul>
        </div>
    </div>
    
    <div class="delatnost">
        <a name="izgradnja-poljoprivrednih-objekata"></a>
        <h2>Izgradnja poljoprivrednih objekata</h2>
    
        <p class="justify">Veliki deo naših radova se odnosi na izradnju silosa,podnih skladišta i farmi</p>
        
        <div id="thumbnails">
            <ul class="clearfix">
                <li class="inline"><a href="/images/izgradnja-poljoprivrednih-objekata.JPG"><img src="/images/izgradnja-poljoprivrednih-objekata.JPG" width="300px" height="200px" alt="Izrada poljoprovrednih objekata" /></a></li>
                <li class="inline"><a href="/images/izgradnja-poljoprivrednih-objekata-1.JPG"><img src="/images/izgradnja-poljoprivrednih-objekata-1.JPG" width="300px" height="200px" alt="Izrada poljoprivrednih objekata" /></a></li>
            </ul>
        </div>
    </div>
    
    <div class="delatnost">
        <a name="izrada-saobracajnica"></a>    
        <h2>Izrada saobraćajnica</h2>
    
        <p class="justify">Izrada saobraćajnica od betona,sa završnom obradom helikoptiranjem (ferobeton) ili četkanjem.
           Kao finšer za asphalt I garniture valjaka za ugradnju asfalthin zastora.</p>
           
        <div id="thumbnails">   
            <ul class="clearfix">
                <li class="inline"><a href="/images/izgradnja-saobracajnica.JPG"><img src="/images/izgradnja-saobracajnica.JPG" width="300px" height="200px" alt="Izrada saobraćajnica" /></a></li>
                <li class="inline"><a href="/images/izgradnja-saobracajnica-1.JPG"><img src="/images/izgradnja-saobracajnica-1.JPG" width="300px" height="200px" alt="Izrada saobraćajnica" /></a></li>
            </ul>
        </div>
    </div>
    
    <div class="delatnost">   
        <a name="izgradnja-spoljnog-vodovoda-i-kanalizacije"></a>
        <h2>Izgradnja spoljnog vodovoda i kanalizacije</h2>
    
        <p class="justify">Imamo veliko iskustvo pri izradi fekalne i atmosverske kanalizacije.Iskop kanala u naselju I 
           van naselja.</p>
        
        <div id="thumbnails">   
            <ul class="clearfix">
                <li class="inline"><a href="/images/izradnja-vodovoda-i-kanalizacije.JPG"><img src="/images/izradnja-vodovoda-i-kanalizacije.JPG" width="300px" height="200px" alt="Izrada vodovoda i kanalizacije" /></a></li>
                <li class="inline"><a href="/images/izradnja-vodovoda-i-kanalizacije.JPG"><img src="/images/izradnja-vodovoda-i-kanalizacije-1.JPG" width="300px" height="200px" alt="Izrada vodovoda i kanalizacije" /></a></li>
            </ul>
        </div>
    </div>
    
    <div class="delatnost">   
        <a name="transport-rasutog-gradjevinskog-materijala"></a>
        <h2>Transport rasutog građevinskog materijala</h2>
    
        <p class="justify">Opremljeni smo savremenim vozilima za prevoz gradjevinskog materijala</p>
        
        <div id="thumbnails">
            <ul class="clearfix">
                <li class="inline"><a href="/images/transport-rasutih-materijala.jpg"><img src="/images/transport-rasutih-materijala.jpg" width="300px" height="200px" alt="Transport rasutog materijala" /></a></li>
                <li class="inline"><a href="/images/transport-rasutih-materijala-1.jpg"><img src="/images/transport-rasutih-materijala-1.jpg" width="300px" height="200px" alt="Transport rasutog materijala" /></a></li>
            </ul>
        </div>
    </div>
    <div class="delatnost">
        <a name="sljunkara-i-separacija-sljunka"></a>
        <h2>Šljunkara i separacija šljunka</h2>
        
        <p class="justify">Ekogradnja doo separaciju šljunka vrši na obali Tise kod Žabaljkog mosta, između Zrenjanina i Novog Sada.</p>
        <p class="justify">Separatisani materijal prvenstveno koristimo za proizvodnju betona, ali vršimo i prodaju sledećih materijala:</p>
        <ul>
            <li>- prirodnog šljunka</li>
            <li>- frakcija 4 - 8 mm, 8 - 16 mm, 16 - 32 mm i iberlaufa</li>
            <li>- tucanika 0/31,5 mm, 0/63 mm</li>
        </ul>
        <p>U mogućnosti smo da ponudimo i uslugu prevoza materijala sopstvenom mehanizacijom.</p>
        <div id="thumbnails">
            <ul class="clearfix">
                <li class="inline"><a href="/images/sljunkara-i-separacija-sljunka.jpg"><img src="/images/sljunkara-i-separacija-sljunka.jpg" width="300px" height="200px" alt="Šljunkara i separacija šljunka" /></a></li>
                <li class="inline"><a href="/images/sljunkara-i-separacija-sljunka-1.jpg"><img src="/images/sljunkara-i-separacija-sljunka-1.jpg" width="300px" height="200px" alt="Šljunkara i separacija šljunka" /></a></li>
                <li class="inline"><a href="/images/sljunkara-i-separacija-sljunka-2.jpg"><img src="/images/sljunkara-i-separacija-sljunka-2.jpg" width="300px" height="200px" alt="Šljunkara i separacija šljunka" /></a></li>
            </ul>
        </div>
    </div>
    <%--<a name="rusenje-objekata"></a>
    <h2>Rušenje objekata sa odvozom otpadnog materijala</h2>
    
    
    
    
    
    
    
    <a name="iskop-kanala"></a>
    <h2>Iskop kanala</h2>
    
    
    
    <a name="secenje-i-sabijanje-betona-i-asfalta"></a>
    <h2>Sečenje i sabijanje betona i asfalta</h2>--%>
    
    <script type="text/javascript">
        $(function() {
            $('#thumbnails a').lightBox();
        });
    </script>
    
    <script type="text/javascript">
        
            var e = document.getElementById("heading")
            e.scrollIntoView();
        
    </script>
</asp:Content>
