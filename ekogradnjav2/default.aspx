<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ekogradnjav2._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row text-center categoryFP">
        <div class="col-md-3">
            <a href="/betonska-galanterija"><h2>Proizvodnja betonske galanterije</h2>
                <img src="/images/betonska-galanterija-1.jpg" class="img-responsive img-center" />
                </a>
            <p class="text-justify margin-top-05">
                <a href="/betonska-galanterija">Behaton ploče</a> iz našeg proizvodnog programa su namenjene popločavanju pešačkih i saobraćajnih površina. Širok spektar 
                upotrebe u različitim okruženjima (dvorišta, parkinzi, saobraćajnice, staze) omogućava raznovrsnost njihovih oblika i 
                boja kao i mogućnost kombinovanja. Osim <strong>betonskih ploča</strong>, bavimo se proizvodnjom <a href="/ivicnjaci">ivičnjaka</a>, <a href="/rigole-i-kanalete">rigola</a>, <a href="/rigole-i-kanalete">kanaleta</a>, kao i <a href="/betonske-cevi-kanalizacioni-elementi">betonskih 
                cevi i šahtova</a>.
            </p>
        </div>
        <div class="col-md-3">
            <a href="/delatnosti#proizvodnja-transportnog-betona"><h2>Fabrika betona</h2>
                <img src="/images/fabrika-betona-1.jpg" class="img-responsive img-center" />
            </a>
            <p class="text-justify margin-top-05">
                Jedna od glavnih delatnosti <a href="/o-nama">Ekogradnje</a> je <strong>proizvodnja i transport betona</strong> za sve aplikacije u građevinarstvu.
                Već više od deset godina uspešno pokrivamo veliki deo tržišta u ovoj oblasti.
                Proizvodnju <strong>betona</strong> vršimo u dve betonske baze kapaciteta 50 m3/h, od kojih je jedna u Zrenjaninu, a druga u Melencima.
                Za <strong>transport betona</strong> do gradilišta koristimo vlastita sredstva transporta.
            </p>
        </div>
        <div class="col-md-3">
            <a href="/delatnosti#uredjenje-i-nivelacija-terena"><h2>Niskogradnja</h2>
                <img src="/images/niskogradnja-1.jpg" class="img-responsive img-center" />
            </a>
            <p class="text-justify margin-top-05">
                <a href="/o-nama">Ekogradnja</a> je specijalozovana za izradu atarskih puteva, otresišta i tucaničkih platoa. Bavimo se i izradom <strong>saobraćajnica
                od betona</strong> sa završnom obradom. Imamo veliko iskustvo u izadi <strong>fekalne</strong> i <strong>atmosferske kanalizacije</strong> kao i pri izradi kanala i u
                naseljima i van naselja.
            </p>
        </div>
        <div class="col-md-3">
            <a href="/delatnosti#sljunkara-i-separacija-sljunka"><h2>Proizvodnja peska i šljunka</h2>
                <img src="/images/proizvodnja-peska-i-sljunka-1.jpg" class="img-responsive img-center" />
            </a>
            <p class="text-justify margin-top-05">
                <a href="/o-nama">Ekogradnja</a> vrši separaciju peska i šljunka. Separatisani materijal se prvenstveno koristi  za <strong>proizvodnju betona</strong>, ali i za dalju prodaju:
                prirodnog šljunka, frakcije i tucanika.
            </p>
        </div>
    </div>
    <div class="row margin-top-2 descriptionFP">
        <div class="col-md-6">
            <h2>Ekogradnja doo, dobrodošli</h2>
            <p class="justify">
                Kompanija <a href="/o-nama"><strong><span class="green">Ekogradnja</span></strong></a> osnovana je 2002. godine registrovana 
                kao samostalna radnja za proizvodnju <a href="/betonska-galanterija">betonske galanterije</a>. 
                Osim <a href="/transportni-beton">proizvodnje betona</a> i betonskih proizvoda bavimo se izvođenjem radova u niskogradnji.
                U toku svog razvoja preduzeće je dosta ulagalo u opremu, ali je svakako najveću investiciju uvek predstavljao stručno 
                osposobljen kadar. Kvalitet betonskih proizvoda je doveden na viši nivo, kao i kapacitet proizvodnje.
            </p>
        </div>
        <div class="col-md-3">
            <h2><a href="/projekti">Projekti</a></h2>
            <asp:Repeater ID="repeaterProjekti" runat="server">
                <ItemTemplate>
                    <div class="projectFP">
                        <img src='<%#Eval("idProjekta","/images/projekti/{0}-1-thumb.jpg") %>' alt='<%#Eval("nazivProjekta") %>' />
                        <a href='<%#Eval("url","/projekti/{0}") %>' title='<%#Eval("nazivProjekta") %>' ><%#Eval("nazivProjekta").ToString().Length > 20 ? Eval("nazivProjekta").ToString().Substring(0, 20) + "..." : Eval("nazivProjekta") %></a>
                        <p><%#Eval("opisProjekta").ToString().Length > 10 ? Eval("opisProjekta").ToString().Substring(0, 10) + "..." : Eval("opisProjekta") %></p>
                        <a class="details" href='<%#Eval("url","/projekti/{0}") %>' title='<%#Eval("nazivProjekta", "Pročitajte više o projektu {0}") %>'><small>detaljnije</small></a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-3">
            <h2>Katalog</h2>
            <p class="justify"><a href="/EkoGradnjaKatalog_m.pdf">Preuzmite katalog</a> naših proizvoda u PDF formatu. U katalogu ćete naći kompletan spisak naših <a href="/proizvodni-program">proizvoda</a> sa detaljnim slikama,
                primerima i opisima, kao i uputsvo za postavljanje betonskih elemenata.
            </p>
            <div class="row">
                <div class="col-xs-4">
                    <a href="/EkoGradnjaKatalog_m.pdf" target="_blank">
                        <img src="/images/katalog.jpg" class="img-responsive" />
                    </a>
                </div>
                <div class="col-xs-4">
                    <a href="/EkoGradnjaKatalog_m.pdf" target="_blank">
                        <img src="/images/katalog1.jpg" class="img-responsive" />
                    </a>
                </div>
                <div class="col-xs-4">
                    <a href="/EkoGradnjaKatalog_m.pdf" target="_blank">
                        <img src="/images/katalog2.jpg" class="img-responsive" />
                    </a>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <%--<h2>Betonska galanterija</h2>
            <asp:Repeater ID="repeaterBetonskaGalanterija" runat="server">
                <ItemTemplate>
                    <div class="productFP">
                        <asp:HyperLink runat="server" NavigateUrl='<%#Eval("url") %>'>
                            <asp:Image runat="server" ImageUrl='<%#Eval("idProizvoda", "/images/proizvodi/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProizvoda") %>' />
                            <span><%#Eval("nazivProizvoda") %></span>
                        </asp:HyperLink>
                    </div>
                </ItemTemplate>
            </asp:Repeater>--%>
        </div>
    </div>
</asp:Content>
