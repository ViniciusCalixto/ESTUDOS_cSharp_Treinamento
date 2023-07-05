<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ProjetoWebAula6.WebForms.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-inverse">
                <div class="container-fluid">
                    <%-- Header do Menu --%>
                    <div class="navbar-header">
                        <a class="navbar-brand" href="#">Meu primeiro Projeto ASP .NET + Bootstrap
                        </a>
                    </div>
                    <%-- Fim Header do Menu --%>
                    <ul class="nav navbar-nav">
                        <li>
                            <a href="#">
                                Home
                            </a>

                        </li>
                         <li>
                            <a href="CadastroUsuario.aspx">
                                Cadastro de Usuario
                            </a>

                        </li>
                         <li>
                            <a href="#">
                                Página 2
                            </a>

                        </li>
                        <li>
                            <a href="#">
                                Página 3
                            </a>

                        </li>
                    </ul>
                </div>
            </nav>
        </div>
    </form>
</body>
</html>
