<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RecipeSite.Site.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Receitas recém criadas:"></asp:Label>
    <div class="card" style="width: 18rem;">
        <img src="..." class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="">Titulo Receita</h5>
            <p class="card-text">classificação e dificuldade</p>
            <a href="#" class="btn btn-primary">Detalhes</a>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <h1>Faça o seu registo para poder partilhar as suas receitas</h1>
            <a href="~/Pages/Register.aspx" runat="server" class="btn btn-primary">Aqui!</a>
        </div>
        <div class="col">
            <h1>Faça Login!</h1>
            <a href="~/Pages/Login.aspx" runat="server" class="btn btn-primary">Aqui!</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
