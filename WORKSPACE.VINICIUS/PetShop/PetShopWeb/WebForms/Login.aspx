<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PetShopWeb.WebForms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="../Content/Login/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>
    
    
    <script src="../Scripts/Login/index.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="login">
        <h1>Plataforma Pet  Login</h1>
        
    	<%--<input type="text" name="u" placeholder="Username" required="required" />
        <input type="password" name="p" placeholder="Password" required="required" />
        <button type="submit" class="btn btn-primary btn-block btn-large">Let me in.</button>--%>

        <asp:TextBox  ID ="txtUsername" placeholder="Username" required="required" runat="server"></asp:TextBox>
        <asp:TextBox  ID ="txtPassword" TextMode="Password" placeholder="Password" required="required" runat="server"></asp:TextBox>
        <asp:Button ID="btnAcesso" CssClass="btn btn-primary btn-block btn-large" runat="server" Text="Entrar" OnClick="btnAcesso_Click" />
        <div>
            <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>

        
    </div>
        <script src="../Scripts/Login/index.js"></script>
    </form>
</body>
</html>
