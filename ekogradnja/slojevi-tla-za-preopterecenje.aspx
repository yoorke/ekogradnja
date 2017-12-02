<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="slojevi-tla-za-preopterecenje.aspx.cs" Inherits="ekogradnja.slojevi_tla_za_preopterecenje" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Slojevi tla za preopterećenje</h1>
    
    <div class="slojeviTla">
        <h2>Podloga za pešačke zone</h2>
        <img src="/images/uputstva/2-1.jpg" alt="Podloga za pešačke zone" />
        <ul>
            <li>1. Ploče</li>
            <li>2. Drobljeni agregat 4-8 mm</li>
            <li>3. Drobljeni kamen 0-31 mm</li>
            <li>4. Pesak</li>
        </ul>
    </div>
    
    <div class="slojeviTla">
        <h2>Podloga za putnička vozila</h2>
        <img src="/images/uputstva/2-2.jpg" alt="Podloga za putnička vozila" />
        <ul>
            <li>1. Ploče</li>
            <li>2. Drobljeni agregat 4-8 mm</li>
            <li>3. Drobljeni kamen 0-31 mm</li>
            <li>4. Pesak</li>
        </ul>
    </div>
    
    <div class="slojeviTla">
        <h2>Podloga za vozila do 3.5 tona</h2>
        <img src="images/uputstva/2-3.jpg" alt="Podloga za vozila do 3.5 tona" />
        <ul>
            <li>1. Ploče</li>
            <li>2. Drobljeni agregat 4-8 mm</li>
            <li>3. Drobljeni kamen 0-31 mm</li>
            <li>4. Pesak</li>
        </ul>
    </div>
    
    <div class="slojeviTla">
        <h2>Podloga za vozila preko 3.5 tona</h2>
        <img src="images/uputstva/2-4.jpg" alt="Podloga za vozila preko 3.5 tona" />
        <ul>
            <li>1. Ploče</li>
            <li>2. Drobljeni agregat 4-8 mm</li>
            <li>3. Drobljeni kamen 0-31 mm</li>
            <li>4. Drobljeni kamen 31-63 mm</li>
            <li>5. Pesak</li>
        </ul>
    </div>
    <script type="text/javascript">
        var e = document.getElementById("heading");
        e.scrollIntoView();
    </script>
    
</asp:Content>
