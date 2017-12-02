<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="gde-se-nalazimo.aspx.cs" Inherits="ekogradnjav2.gde_se_nalazimo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Gde se nalazimo</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div id="map"></div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
    <script>
        //function loadScripts() {
            //var element = document.createElement('script');
            //element.src = "http://maps.google.com/maps/api/js?sensor=false";
            //document.body.appendChild(element);

            //var element1 = document.createElement('script');
            //element1.src = "/js/map.js";
            //document.body.appendChild(element1);
        //}
        //if (window.addEventListener)
            //window.addEventListener("load", loadScripts, false);
        //else if (window.attachEvent)
            //window.attachEvent("onload", loadScripts);
        //else window.onload = loadScripts;
    </script>
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
    <!--<script type="text/javascript" src="/js/map.js"></script>-->
</asp:Content>
