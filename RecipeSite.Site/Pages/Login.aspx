<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RecipeSite.Site.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <br />
    <h1>Iniciar Sessão</h1>
    <br />
    <hr />

    <div class="row">
        <div class="col">
            <asp:Login ID="Login1" runat="server">
                <LayoutTemplate>
                    <div class="form-group">
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nome de Usuário:</asp:Label>
                        <asp:TextBox CssClass="form-control" ID="UserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Palavra-Chave:</asp:Label>
                        <asp:TextBox CssClass="form-control" ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:CheckBox CssClass="form-check-label" ID="RememberMe" runat="server" Text="Ficar lembrado" />
                    </div>
                    <div class="form-group">
                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                    </div>
                    <div class="form-group">
                        <asp:Button CssClass="btn btn-primary" ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" />
                    </div>
                </LayoutTemplate>
            </asp:Login>
        </div>
        <div class="col">
            <h3> Ainda não está registado?</h3>
            <a href="~/Pages/Register.aspx" runat="server" class="btn btn-primary">Faça aqui!</a>
        </div>
    </div>
    <hr />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
