<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PetShopWeb.WebForms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css" />
    <link href="../Content/Login/style.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <h1>Plataforma Pet - Login</h1>
            <asp:TextBox ID="txtUserName" placeholder="Username" required="required" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPassword" TextMode="Password" placeholder="Password" required="required" runat="server"></asp:TextBox>
            <asp:Button ID="btnEntrar" CssClass="btn btn-primary btn-block btn-large" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
            <div>
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            </div>
        </div>
        <script src="../Scripts/Login/index.js"></script>
    </form>
</body>
</html>
