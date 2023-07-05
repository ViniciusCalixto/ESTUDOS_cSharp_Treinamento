<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="ProjetoWebAula6.WebForms.CadastroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Usuários</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Cadastro de Usuário</h2>
        <div class="form-group">
            
            <asp:TextBox ID="txtNome" placeholder="Digite o seu nome :)" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="label label-danger" ControlToValidate="txtNome" ID="validacaoNome" runat="server" ErrorMessage="Campo obrigatório"></asp:RequiredFieldValidator>
        </div>
        
        <div class="form-group">
            
            <asp:TextBox ID="txtLogin" placeholder="Digite o seu login" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtLogin" CssClass="label label-danger" ID="validacaoLogin" runat="server" ErrorMessage="Campo obrigatório"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            
            <asp:TextBox ID="txtSenha" placeholder="Digite a senha" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtSenha" CssClass="label label-danger" ID="validacaoSenha" runat="server" ErrorMessage="Campo obrigatório"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtConfirmarSenha" placeholder="Confirme sua senha" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtConfirmarSenha" CssClass="label label-danger" ID="validacaoConfirmarSenha" runat="server" ErrorMessage="Campo obrigatório"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="compararSenhas" CssClass="label label-warning" runat="server" ErrorMessage="As senhas não batem" ControlToCompare="txtSenha" ControlToValidate="txtConfirmarSenha"></asp:CompareValidator>
        </div>
        <div>
            <asp:Button ID="btnCadastrar" CssClass="btn btn-primary" runat="server" Text="Cadastrar" />
            
        </div>
    </div>
    </form>
</body>
</html>
