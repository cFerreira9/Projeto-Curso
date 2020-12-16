<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RecipeSite.Site.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <br />
    <hr />
    <h3>Receitas recém criadas:</h3>
    <br />
    <div id="RecipesCardContainer" runat="server">

        <!-- Card deck -->
        <div class="card-deck">

            <!-- Card -->
            <div class="card mb-4" id="card1" runat="server">

                <!--Card image-->
                <div class="view overlay">
                    <img class="card-img-top" src="https://mdbootstrap.com/img/Photos/Others/images/16.jpg"
                        alt="Card image cap" id="pic1" runat="server">
                    <a href="#!">
                        <div class="mask rgba-white-slight"></div>
                    </a>
                </div>

                <!--Card content-->
                <div class="card-body">

                    <!--Title-->
                    <h4 class="card-title" id="title1" runat="server">Card title</h4>
                    <!--Text-->
                    <p class="card-text" id="text1" runat="server">Some quick example text to build on the card title and make up the bulk of the card's
      content.</p>
                    <!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
                    <button type="button" class="btn btn-secondary" id="btn1" runat="server">Detalhes</button>

                </div>

            </div>
            <!-- Card -->

            <!-- Card -->
            <div class="card mb-4" id="card2" runat="server">

                <!--Card image-->
                <div class="view overlay">
                    <img class="card-img-top" src="https://mdbootstrap.com/img/Photos/Others/images/14.jpg"
                        alt="Card image cap">
                    <a href="#!">
                        <div class="mask rgba-white-slight"></div>
                    </a>
                </div>

                <!--Card content-->
                <div class="card-body">

                    <!--Title-->
                    <h4 class="card-title">Card title</h4>
                    <!--Text-->
                    <p class="card-text">
                        Some quick example text to build on the card title and make up the bulk of the card's
        content.
                    </p>
                    <!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
                    <button type="button" class="btn btn-secondary">Detalhes</button>
                </div>

            </div>
            <!-- Card -->

            <!-- Card -->
            <div class="card mb-4" id="card3" runat="server">

                <!--Card image-->
                <div class="view overlay">
                    <img class="card-img-top" src="https://mdbootstrap.com/img/Photos/Others/images/15.jpg"
                        alt="Card image cap">
                    <a href="#!">
                        <div class="mask rgba-white-slight"></div>
                    </a>
                </div>

                <!--Card content-->
                <div class="card-body">

                    <!--Title-->
                    <h4 class="card-title">Card title</h4>
                    <!--Text-->
                    <p class="card-text">
                        Some quick example text to build on the card title and make up the bulk of the card's
        content.
                    </p>
                    <!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
                    <button type="button" class="btn btn-secondary">Detalhes</button>
                </div>
            </div>
        </div>
    </div>
    <hr />
    <br />
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            <div class="row">
                <div class="col">
                    <h3>Faça o seu registo para poder partilhar as suas receitas</h3>
                    <a href="~/Pages/Register.aspx" runat="server" class="btn btn-primary">Aqui!</a>
                </div>
                <div class="col">
                    <h3>Faça Login!</h3>
                    <a href="~/Pages/Login.aspx" runat="server" class="btn btn-primary">Aqui!</a>
                </div>
            </div>
            <hr />
        </AnonymousTemplate>
    </asp:LoginView>
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
