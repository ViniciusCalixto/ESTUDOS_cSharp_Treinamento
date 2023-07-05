<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ProjetoWebAula6.WebForms.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <%--para comentar usar ctrl + K + C--%>
    <%--para descomentar ctrl + k + U--%>


    <%--Instanciando bootstrap--%>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.js"></script>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-inverse">
                <div class="container-fluid"> <%--Inicio header do Menu--%>
                    <div class="navbar-header">
                        <a class="navbar-brand" href="#">
                            Meu Primeiro Projeto Asp .Net com Bootstrap
                        </a>
                    </div><%--Fim header do Menu--%>
                    <ul class="nav navbar-nav">
                        <li>
                            <a href ="#">
                                Home
                            </a>
                        </li>
                        <li>
                            <a href ="CadastroUsuario.aspx">
                                Cadastro de Usuário
                            </a>
                        </li>
                        <li>
                            <a href ="#">
                                Pag 2
                            </a>
                        </li>
                        <li>
                            <a href ="#">
                                Pag 3
                            </a>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
    </form>
</body>
</html>
