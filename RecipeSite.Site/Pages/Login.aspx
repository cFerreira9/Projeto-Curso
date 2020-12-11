<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RecipeSite.Site.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <h1>Login</h1>
    <div class="form-group">
        <label for="exampleInputUser1">Nome de Usuário</label>
        <asp:TextBox ID="UsernameTxt" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Palavra-Chave</label>
        <asp:TextBox ID="PasswordTxt" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group form-check">
        <input type="checkbox" class="form-check-input" id="exampleCheck1">
        <label class="form-check-label" for="exampleCheck1" >Lembrar-me!</label>
    </div>
    <button type="submit" class="btn btn-primary">Entrar</button>
    <h3>Ainda não está registado?</h3>
    <button type="submit" class="btn btn-primary">Clique aqui!</button>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
