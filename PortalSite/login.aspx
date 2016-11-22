<%@ Page Title="login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
 <asp:Panel CssClass="loginForm" runat="server">

 
                    
    <asp:Panel CssClass="input-group fixedPadding fixedWidth" runat="server">
        <asp:Label ID="UserNameLabel" CssClass="input-group-addon fixedWidth2" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
        <asp:TextBox ID="UserName" CssClass="form-control" runat="server"></asp:TextBox>
    </asp:Panel>
                            
    <asp:Panel CssClass="input-group fixedPadding fixedWidth" runat="server">
        <asp:Label ID="PasswordLabel" CssClass="input-group-addon fixedWidth2" runat="server" AssociatedControlID="Password">Password:</asp:Label>
        <asp:TextBox ID="Password"  CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
    </asp:Panel> 
     <asp:Panel ID="message" CssClass="alert alert-danger text-center" Visible="false" runat="server">Wrong Username or Password!</asp:Panel>                                              
    <asp:Button ID="LoginButton" runat="server" CssClass="btn btn-default fixedMargin pullLeft" CommandName="Login" OnClick="login_click" Text="Log In" ValidationGroup="Login1" />

</asp:Panel>
</asp:Content>
