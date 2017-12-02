<%@ Page Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="ostalo.aspx.cs" Inherits="ekogradnja.ostalo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a id="heading" name="heading"></a>
    <h1>Ostalo</h1>
    
    <asp:Repeater ID="repeaterOstalo" runat="server">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        
        <ItemTemplate>
            <li class="proizvodLi">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("url","{0}") %>'><asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("idProizvoda","/images/proizvodi/{0}-1-thumb.jpg") %>' AlternateText='<%#Eval("nazivProizvoda") %>' />
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
