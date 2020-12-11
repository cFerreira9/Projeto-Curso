<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RecipeSite.Site.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <h1>Registo</h1>
    <div class="form-group">
        <label for="exampleInputUser1">Nome de Usuário</label>
        <asp:TextBox ID="UsernameTxt" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Email</label>
        <asp:TextBox ID="EmailTxt" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Palavra-Chave</label>
        <asp:TextBox ID="PasswordTxt" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputPassword2">Confirme a Palavra-Chave</label>
        <asp:TextBox ID="CheckPasswordTxt" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <button type="submit" class="btn btn-primary">Registar</button>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
