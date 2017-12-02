<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page.aspx.cs" Inherits="ekogradnja.administrator.page" ValidateRequest="false" %>
<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td>
                    idPage:
                </td>
                <td>
                    <asp:TextBox ID="txtIdPage" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    Title:
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    Description:
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    Keywords:
                </td>
                <td>
                    <asp:TextBox ID="txtKeywords" runat="server"></asp:TextBox>            
                </td>
            </tr>
            
            <tr>
                <td>
                    Content:
                </td>
                <td>
                    <FTB:FreeTextBox ID="txtContent" runat="server"></FTB:FreeTextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    Url:
                </td>
                <td>
                    <asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>
                </td>
            </tr>
            
        </table>
        
        <asp:Button ID="btnSacuvaj" runat="server" OnClick="btnSacuvaj_Click" Text="Save" />
        
        
        
    </div>
    </form>
</body>
</html>
