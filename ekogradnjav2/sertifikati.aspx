<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="sertifikati.aspx.cs" Inherits="ekogradnjav2.sertifikati" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1>Sertifikati</h1>
        </div>
    </div>
    <div class="row" id="thumbnails">
        <div class="col-md-3">
            <a href="/images/certificate-9001.jpg">
                <img src="/images/certificate-9001.jpg" class="img-responsive" srcset="/images/certificate-9001-lg.jpg 1200w, /images/certificate-9001-md.jpg 950w, /images/certificate-9001-sm.jpg 750w, /images/certificate-9001-xs.jpg 500w" />
            </a>
        </div>
        <div class="col-md-3">
            <a href="/images/certificate-14001.jpg">
                <img src="/images/certificate-14001.jpg" class="img-responsive" />
            </a>
        </div>
        <div class="col-md-3">
            <a href="/images/certificate-18001.jpg">
                <img src="/images/certificate-18001.jpg" class="img-responsive" />
            </a>
        </div>
        <div class="col-md-3">
            <a href="/images/certificate-50001.jpg">
                <img src="/images/certificate-50001.jpg" class="img-responsive" />
            </a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
</asp:Content>
