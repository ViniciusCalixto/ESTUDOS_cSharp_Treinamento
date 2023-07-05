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
            <%--<label for="nomeusuario">
                Nome Usuário:
            </label>--%>
            <%--<input type="text" class="form-control", id ="txtNome"/>--%>
            <asp:TextBox ID="txtNome" placeholder="Digite o seu Nome:" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="label label-danger" ControlToValidate="txtNome" ID="validacaonome" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <%--<label for="loginusuario">
                Login Usuário:
            </label>--%>
            <%--<input type="text" class="form-control", id ="txtLogin"/>--%>
            <asp:TextBox ID="txtLogin" placeholder="Digite o seu Login:" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="label label-danger" ControlToValidate="txtLogin" ID="validacaologin" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <%--<label for="senhausuario">
                Senha Usuário:
            </label>--%>
            <%--<input type="password" class="form-control", id ="txtSenha"/>--%>
            <asp:TextBox ID="txtSenha"  placeholder="Digite a sua Senha:" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="label label-danger" ControlToValidate="txtSenha" ID="validacaosenha" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <%--<label for="senhausuario">
                Senha Usuário:
            </label>--%>
            <%--<input type="password" class="form-control", id ="txtSenha"/>--%>
            <asp:TextBox ID="txtConfirmaSenha"  placeholder="Confirme a sua Senha:" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator  CssClass="label label-danger" ControlToValidate="txtConfirmaSenha" ID="ConfirmaSenha" runat="server" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="comparaSenhas" CssClass="label label-warning"  runat="server" ErrorMessage="Senhas devem ser iguais!" ControlToValidate="txtConfirmaSenha" ControlToCompare="txtSenha"></asp:CompareValidator>
        </div>
        

        <div>
            <%--<button type="button" class="btn-primary">
                Cadastrar
            </button>--%>
            <asp:Button ID="btnCadastrar" CssClass="btn btn-primary" runat="server" Text="Cadastrar" />
        </div>
    </div>
    </form>
</body>
</html>
