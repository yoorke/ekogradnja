 <%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="proizvodni-program.aspx.cs" Inherits="ekogradnja.proizvodni_program" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Proizvodni program</h1>
    
    <ul>
        <li class="proizvodniProgramLi"><img src="/images/proizvodi/1-1-thumb.jpg" width="90px" height="90px" alt="Betonska galanterija" title="Betonska galanterija se pokazala izvrsnom za harmoničnu simbiozu sa dvorišnom hortikulturom. Uređenje gradskih ulica, trgova, parkova je već nezamislivo bez primene betonske galanterije." /><a href="/betonska-galanterija">Betonska galanterija</a></li>
        <li class="proizvodniProgramLi"><img src="/images/proizvodi/12-1-thumb.jpg" width="90px" height="90px" alt="Ivičnjaci" title="Ivičnjaci" /><a href="/ivicnjaci">Ivičnjaci</a></li>
        <li class="proizvodniProgramLi"><img src="/images/proizvodi/18-1-thumb.jpg" width="90px" height="90px" alt="Rigole" title="Rigole su specijalno izradjeni za visoku otpornost na mraz i otprnosnt na hemijske agense, čvrstoću na pritisak, visok estetski kvalitet." /><a href="/rigole">Rigole</a></li>
        <li class="proizvodniProgramLi"><img src="/images/proizvodi/19-1-thumb.jpg" width="90px" height="90px" alt="Betonske cevi i kanalizacioni elementi" title="Betonske cevi i kanalizacioni elementi" /><a href="/betonske-cevi-kanalizacioni-elementi">Betonske cevi i kanalizacioni elementi</a></li>
        <li class="proizvodniProgramLi"><img src="/images/transportni-beton.jpg" width="90px" height="90px" alt="Transportni beton i agregat" title="Proizvodimo standardan asortiman običnog i pumpanog betona (MB 15 do MB 50), kao i specijalne vrste betona: vodonepropusni beton, betone otporne na delovanje mraza, SCC beton, VDP beton." /><a href="/transportni-beton">Transportni beton i agregat</a></li>
        <li class="proizvodniProgramLi"><img src="/images/proizvodi/27-1-thumb.jpg" width="90px" height="90px" alt="Ostalo" title="Ostali betonski elementi" /><a href="/ostalo">Ostalo</a></li>
    </ul>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        e.scrollIntoView();
    </script>
</asp:Content>
