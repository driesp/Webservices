<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel id="panelContent" CssClass="panel-container" runat="server">
        <asp:Panel CssClass=" panel-tall col-md-3 " runat="server">
            <iframe class="frame" src="http://www.ftsolutions.be" width="100%" height="100%" scrolling="no">
                 <p>Your browser does not support iframes.</p>
            </iframe>
            <asp:Panel CssClass="overlay" runat="server" onclick="window.location.href = 'http://www.ftsolutions.be'">
            </asp:Panel>
        </asp:Panel>
        <asp:Panel CssClass="panel-tall col-md-3 " runat="server">
            <iframe class="frame" src="http://www.ftsolutions.be" width="100%" height="100%" scrolling="no">
                 <p>Your browser does not support iframes.</p>
            </iframe>
            <asp:Panel CssClass="overlay" runat="server" onclick="window.location.href = 'http://www.ftsolutions.be'">
            </asp:Panel>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
