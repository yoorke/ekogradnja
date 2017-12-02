<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ekogradnja.Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="Ekogradnja je kompanija koja se bavi proizvodnjom i ugradnjom betonske galanterije, proizvodnjom transportnog betona i izvođenjem radova u niskogradnji." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="columnWrapper">
        <div class="column prvi">
            <h2 class="naslov"><span class="zeleniTekst">Eko</span>gradnja doo, dobrodošli</h2>
            <%--<img class="columnImg" src="images/house.jpg" />--%>
            <p class="columnText lineheight15">
                Kompanija <a href="/o-nama" class="tekst bold">Ekogradnja</a> osnovana je 2002. godine registrovana 
                kao samostalna radnja za proizvodnju <a href="/betonska-galanterija" class="tekst">betonske galanterije</a>. 
                Osim <a href="/transportni-beton" class="tekst">proizvodnje betona</a> i betonskih proizvoda bavimo se izvođenjem radova u niskogradnji. U toku svog razvoja
                preduzeće je dosta ulagalo u opremu, ali je svakako najveću investiciju uvek predstavljao stručno 
                osposobljen kadar. Kvalitet betonskih proizvoda je doveden na viši nivo, kao i kapacitet proizvodnje.
            </p>
            <a href="/o-nama" class="dalje" title="Pročitajte više o nama">detaljnije</a>
        </div>
            
        <div class="crta"></div>
            
        <div class="column">
            <h2 class="naslov">Projekti</h2>
            
            <asp:Repeater ID="repeaterProjekti" runat="server">
                <ItemTemplate>
                    <div class="projectFP">
                        <img class="columnImg imgBorder" src='<%#Eval("idProjekta","/images/projekti/{0}-1-thumb.jpg") %>' width="65px" height="55px" alt='<%#Eval("nazivProjekta") %>' />
                        <a href='<%#Eval("url","/projekti/{0}") %>' class="columnLink zeleniTekst"><%#Eval("nazivProjekta") %></a>
                        <p class="columnText"><%#Eval("opisProjekta") %></p>
                        <a href='<%#Eval("url","/projekti/{0}") %>' class="dalje" title='<%#Eval("nazivProjekta", "Pročitajte više o projektu {0}") %>'>detaljnije</a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            
            <%--<img class="columnImg imgBorder" src="images/be28adfff47893c4519c1307dc6b8866_L.jpg" width="65px" height="55px" />
            <a href="#" class="columnLink zeleniTekst">Izrada saobraćajnica za Mirotin Energo Vrbas</a>
            <p class="columnText">Upravo je završen projekat izrade saobracajnice i parkinga u PP Sava Kovacević u Vrbasu ,fabrici bio gasa</p>
            <a href="#" class="dalje">detaljnije</a>
            <img class="columnImg imgBorder" src="images/83c2446a0896df0a1f4af01c940ae1d9_L.jpg" width="65px" height="55px" />
            <a href="#" class="columnLink">Izrada Skejt parka</a>
            <p class="columnText">Prateći zahteve tržišta i svojih klijenata za što preciznijom i bržom ugradnjom AB i betonskih podnih obloga firma Eko gradnja d.o.o. počela je sa rad...</p>
            <a href="#" class="dalje">detaljnije</a>--%>
        </div>
            
        <div class="crta"></div>
            
        <div class="column column200">
            <h2 class="naslov column200">Katalog</h2>
            <p class="columnText"><a href="EkoGradnjaKatalog_m.pdf" class="columnLink" target="_blank">Preuzmite katalog</a> naših proizvoda u PDF formatu.</p>
            <a href="EkoGradnjaKatalog_m.pdf" target="_blank" title="Katalog proizvoda betonska galanterija"><img src="images/katalog.jpg" width="100px" height="141px" class="columnImg" alt="Katalog proizvoda" /></a>
            <!--<a href="#" class="columnLink">Izrada skejt parka</a>
            <img src="images/4695cb3b19cbf906e45dac0da0913068_S.jpg" />-->
        </div>
            
        <!--<div class="crta"></div>-->
            
        <div class="column column750">
            <h2 class="naslov column750">Betonska galanterija</h2>
            <!--<img src="images/ploca-3030_360x226_f53ce142949a4fd1aba9f672ec3feea9.jpg" width="100px" height="100px" />
            <p class="columnText">
                Iako je oblik ovih ploča na prvi pogled veoma jednostavan, pruža mnogo mogućnosti.
                Ne samo varijacije boja i završne obrade,ali i lako kombinacija sa drugimelementima nase ponude.
            </p>-->
            
            <asp:Repeater ID="repeaterProizvodi" runat="server">
                <ItemTemplate>
                    <div class="proizvodPrvaStrana">
                        <asp:HyperLink runat="server" NavigateUrl='<%#Eval("url") %>'><asp:Image runat="server" ImageUrl='<%#Eval("idProizvoda","/images/proizvodi/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProizvoda") %>' Width="90px" Height="90px" /><%#Eval("nazivProizvoda") %></asp:HyperLink>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            
            <a href='/betonska-galanterija' class="dalje" title="Pogledajte sve proizvode iz kategorije betonska galanterija">pogledaj sve</a>
            
            
            
                <%-- <!--<HeaderTemplate>
                    <div id="containerPhotobanner">
                <div class="photobanner">
                </HeaderTemplate>
                
                <ItemTemplate>
                    <asp:HyperLink runat="server" NavigateUrl='<%#Eval("url", "{0}") %>'><asp:Image runat="server" CssClass='<%#Container.ItemIndex==0?"first":"" %>' ImageUrl='<%#Eval("idProizvoda", "/images/proizvodi/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProizvoda") %>' Width="100px" Height="77px" /><asp:Label ID="lblNaziv" runat="server" Text='<%#Eval("nazivProizvoda") %>'></asp:Label></asp:HyperLink>
                </ItemTemplate>
                
                <FooterTemplate>
                    </div>
                    </div>
                </FooterTemplate>-->--%>
            
            
            <!--<div id="containerPhotobanner">
                <div class="photobanner">
                    <img class="first" src="images/ploca1530_360x261_bce6a089c8426e4f93e23e75321d0092.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca2020_360x275_086c641bad068ca37f176e2c2a6846f2.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca2030_360x237_480980c076a201d8491e469ebdc9504d.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca 3030.jpg" width="100px" height="77px" />
                    <img class="" src="images/raster.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca1020_360x247_f6ab9191abe33b9de5618dca671513bc.jpg" width="100px" height="77px" />
                    <img class="" src="images/behaton_360x209_c0176cf2fd5d403a6b69f421c1d83754.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca1530_360x261_bce6a089c8426e4f93e23e75321d0092.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca2020_360x275_086c641bad068ca37f176e2c2a6846f2.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca2030_360x237_480980c076a201d8491e469ebdc9504d.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca 3030.jpg" width="100px" height="77px" />
                    <img class="" src="images/raster.jpg" width="100px" height="77px" />
                    <img class="" src="images/ploca1020_360x247_f6ab9191abe33b9de5618dca671513bc.jpg" width="100px" height="77px" />
                    <img class="" src="images/behaton_360x209_c0176cf2fd5d403a6b69f421c1d83754.jpg" width="100px" height="77px" />
                </div>
            </div>-->
                    
            <!--<ul class="betonskaGalanterija">
                    <li><h3><a href="#"><img class="columnImg" src="images/ploca1530_360x261_bce6a089c8426e4f93e23e75321d0092.jpg" width="100px" height="77px" />
                        Ploca 15x30</a></h3></li>
                        <li><a href="#"><img class="columnImg" src="images/ploca2020_360x275_086c641bad068ca37f176e2c2a6846f2.jpg" width="100px" height="77px" />
                        Ploca 20x20</a></li>
                        <li><a href="#"><img class="columnImg" src="images/ploca2030_360x237_480980c076a201d8491e469ebdc9504d.jpg" width="100px" height="77px" />
                        Ploca 15x30</a></li>
                        <li><a href="#"><img class="columnImg" src="images/ploca 3030.jpg" width="100px" height="77px" />
                        Ploca 30x30</a></li>
                        <li><a href="#"><img class="columnImg" src="images/raster.jpg" width="100px" height="77px" />
                        Raster ploca</a></li>
                        <li><a href="#"><img class="columnImg" src="images/ploca1020_360x247_f6ab9191abe33b9de5618dca671513bc.jpg" width="100px" height="77px" />
                        Ploca 10x20</a></li>
                        <li><a href="#"><img class="columnImg" src="images/behaton_360x209_c0176cf2fd5d403a6b69f421c1d83754.jpg" width="100px" height="77px" />
                        Behaton</a></li>
                    </ul>-->
        </div>
                
        <div class="crta"></div>
                
            <div class="column column200">
                <h2 class="naslov column200">Novosti</h2>
            </div>
            
        </div>
        
</asp:Content>
