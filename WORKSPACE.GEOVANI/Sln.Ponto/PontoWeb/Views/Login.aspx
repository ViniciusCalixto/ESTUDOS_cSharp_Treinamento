<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PontoWeb.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Controle Ponto</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtLogin" placeholder="Digite o usuário" required runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtSenha" placeholder="Digite a senha" TextMode="Password" required runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
        <br />
        <asp:Label ID="lblMensagem" Font-Bold="true" ForeColor="Red" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
