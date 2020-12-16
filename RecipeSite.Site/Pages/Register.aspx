<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RecipeSite.Site.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <br />
    <h1>Registo</h1>
    <br />
    <hr />
    <br />
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CompleteSuccessText="Foi registado com sucesso." ConfirmPasswordCompareErrorMessage="As palavras-chave têm que ser iguais." ConfirmPasswordLabelText="Confirme a palavra-chave:" ConfirmPasswordRequiredErrorMessage="A confirmação da password é ogrigatória." ContinueButtonText="Avançar" CreateUserButtonText="Registar" DuplicateEmailErrorMessage="O e-mail já está a ser utilizado. Por favor utilize outro." DuplicateUserNameErrorMessage="Nome de usuário já está a ser utilizado." EmailRegularExpressionErrorMessage="Introduza outro e-mail." EmailRequiredErrorMessage="E-mail obrigatório." InvalidEmailErrorMessage="Introduza um e-mail válido." PasswordLabelText="Palavra-Chave:" PasswordRegularExpressionErrorMessage="Plavra-Chave inválida." PasswordRequiredErrorMessage="Palavra-Chave é obrigatória." UnknownErrorMessage="A sua conta não foi criada. Tente novamente." UserNameLabelText="Nome de Usuário:" UserNameRequiredErrorMessage="Nome de usuário obrigatório." ContinueDestinationPageUrl="~/Default.aspx" OnCreatedUser="CreateUserWizard1_CreatedUser" OnLoad="Page_Load">
        <WizardSteps>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                <ContentTemplate>
                    <div class="form-group">
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nome de Usuário:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="Nome de usuário obrigatório." ToolTip="Nome de usuário obrigatório." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Palavra-Chave:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Palavra-Chave é obrigatória." ToolTip="Palavra-Chave é obrigatória." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirme a palavra-chave:</asp:Label>
                        <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="A confirmação da password é ogrigatória." ToolTip="A confirmação da password é ogrigatória." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                        <asp:TextBox ID="Email" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="E-mail obrigatório." ToolTip="E-mail obrigatório." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="As palavras-chave têm que ser iguais." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                    </div>
                    <div class="form-group">
                        <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                    </div>
                </ContentTemplate>
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
    <br />
    <hr />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
