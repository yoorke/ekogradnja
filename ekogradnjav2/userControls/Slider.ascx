<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Slider.ascx.cs" Inherits="ekogradnjav2.userControls.Slider" %>
<div class="row slider">
    <div class="col-xs-12 padding-left-0 padding-right-0">
        <asp:Repeater ID="rptSlider" runat="server" OnItemDataBound="rptSlider_ItemDataBound">
            <HeaderTemplate>
                <div class="camera_wrap camera_azure_skin" id="camera_wrap_1">
            </HeaderTemplate>
            <ItemTemplate>
                <div data-thumb='' data-src='<%#"/images/" + Eval("imageUrl") %>'>
                    <div class="camera_caption" runat="server" id="divCaption"><asp:Literal ID="lblCaption" runat="server" Text='<%#Eval("caption") %>'></asp:Literal></div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</div>