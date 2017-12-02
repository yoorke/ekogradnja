<%@ Page Title="" Language="C#" MasterPageFile="~/ekogradnja.Master" AutoEventWireup="true" CodeBehind="proizvod.aspx.cs" Inherits="ekogradnjav2.proizvod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="proizvod"><asp:Literal ID="lblNaziv" runat="server"></asp:Literal></h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div id="like" runat="server"></div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="proizvod">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="updatePanel1" runat="server">
                    <ContentTemplate>
        
                        <div class="row">
                            <div class="col-md-4">
                                <div id="slike">
                                    <asp:Image ID="imgProizvod" runat="server" CssClass="img-responsive" />
        
                                    <asp:ImageButton ID="imgProizvod1" runat="server" Width="50px" Height="50px" CssClass="thumb" BorderStyle="Solid" BorderWidth="1px" OnClientClick="changeImage(this.src);return false;" />
                                    <asp:ImageButton ID="imgProizvod2" runat="server" Width="50px" Height="50px" CssClass="thumb" BorderStyle="Solid" BorderWidth="1px" OnClientClick="changeImage(this.src);return false;" />
                                    <asp:ImageButton ID="imgProizvod3" runat="server" Width="50px" Height="50px" CssClass="thumb" BorderStyle="Solid" BorderWidth="1px" OnClientClick="changeImage(this.src);return false;" />
                                    <asp:ImageButton ID="imgProizvod4" runat="server" Width="50px" Height="50px" CssClass="thumb" BorderStyle="Solid" BorderWidth="1px" OnClientClick="changeImage(this.src);return false;" />
        
                                </div>
                            </div>
                            <div class="col-md-8">
                                
    
                        <div class="opisProizvoda">
                            <div class="row">
                                <div class="col-lg-12">
                                    <p><asp:Label ID="lblOpisProizvoda" runat="server"></asp:Label></p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12">
                                    <asp:Image class="imgDimenzije" ID="imgDimenzije" runat="server" />
                                </div>
                            </div>
                            
                
                            <!--<asp:Image class="imgBoje" ID="imgBoje" runat="server" />-->
                
                            <!--<asp:Image class="imgPrimer" ID="imgPrimer" runat="server" Width="300px" />-->
                            <div class="row">
                                <div class="col-lg-12">
                            <h2>Dimenzije elemenata</h2>
                            <asp:GridView ID="dgvDimenzije1" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#89c54f" CssClass="gridDimenzije">
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate><asp:Label ID="lblIdDimenzije" runat="server" Text='<%#Eval("idDimenzije") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="100px" HeaderText="Oznaka">
                                        <ItemTemplate><asp:Label ID="lblNazivDimenzije" runat="server" Text='<%#Eval("nazivDimenzije") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="d x š [cm]">
                                        <ItemTemplate><asp:Label ID="lblDimenzija" runat="server" Text='<%#Eval("dimenzijaProizvoda") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="kom/m2">
                                        <ItemTemplate><asp:Label ID="lblBrojKomada" runat="server" Text='<%#Eval("brojKomada") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="m2/pal">
                                        <ItemTemplate><asp:Label ID="lblBrojNaPaleti" runat="server" Text='<%#Eval("brojNaPaleti") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                
                            <asp:GridView ID="dgvDimenzije2" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#89c54f" CssClass="gridDimenzije">
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate><asp:Label ID="lblIdDimenzije1" runat="server" Text='<%#Eval("idDimenzije") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="100px" HeaderText="Oznaka">
                                        <ItemTemplate><asp:Label ID="lblNazivDimenzije1" runat="server" Text='<%#Eval("nazivDimenzije") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="L [mm]">
                                        <ItemTemplate><asp:Label ID="lblL" runat="server" Text='<%#Eval("L") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="D [mm]">
                                        <ItemTemplate><asp:Label ID="lblD" runat="server" Text='<%#Eval("D") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="c [mm]">
                                        <ItemTemplate><asp:Label ID="lblC" runat="server" Text='<%#Eval("C") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="e [mm]">
                                        <ItemTemplate><asp:Label ID="lblE" runat="server" Text='<%#Eval("E") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                        
                                    <asp:TemplateField ControlStyle-Width="50px" HeaderText="Tež [kg/kom]"> 
                                        <ItemTemplate><asp:Label ID="lblTezina" runat="server" Text='<%#Eval("tezina") %>'></asp:Label></ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>                
                            </asp:GridView>
                                    </div>
                                </div>
                            
                            <div class="row">
                                <div class="col-lg-12">
                            <h2>Dostupne boje:</h2>
                
                            <asp:Repeater ID="repeaterBoje" runat="server">
                                <HeaderTemplate>
                                    <div id="boje">        
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="boja">
                                        <h4><asp:Label ID="lblNazivBoje" runat="server" Text='<%#Eval("nazivBoje") %>'></asp:Label></h4>
                                        <asp:Image ID="imgBoja" runat="server" ImageUrl='<%#Eval("url") %>' AlternateText='<%#Eval("nazivBoje") %>' />
                                    </div>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </div>        
                                </FooterTemplate>
                            </asp:Repeater>
                                    </div>
                                </div>
                
                
                            <p>Pogledajte <asp:HyperLink id="lnkSemePolaganja" runat="server" CssClass="tekst">sheme polaganja elemenata za proizvod <asp:Label ID="lblNazivProizvoda" runat="server"></asp:Label></asp:HyperLink></p>
                        </div>
                                </div>
                        </div>
                    </ContentTemplate>        
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderFooter" runat="server">
    <script type="text/javascript">
        function changeImage(imageUrl) {
            var image = document.getElementById("ContentPlaceHolder1_imgProizvod");
            image.src = imageUrl.toString().substring(0, imageUrl.toString().indexOf("-thumb")) + ".jpg";
        }
    </script>
</asp:Content>
