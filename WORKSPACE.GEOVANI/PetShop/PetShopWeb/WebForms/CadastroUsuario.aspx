<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="PetShopWeb.WebForms.CadastroUsuario" MasterPageFile="~/Site.Master" %>

<asp:Content ID="containerPadrao" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastro de Usuário</h2>

    <div class="panel panel-primary">
        <div class="panel-heading">Cadastro</div>
        <%--Cabeçalho do paniel--%>
        <div class="panel-body">
            <%--Conteúdo do Painel--%>
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox CssClass="form-control" required ID="txtNome" placeholder="Digite o nome do usuário" runat="server"></asp:TextBox>
                </div>

            </div>
            <br />
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox CssClass="form-control" required ID="txtLogin" placeholder="Digite o login" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox CssClass="form-control" required TextMode="Password" ID="txtSenha" placeholder="Digite a senha" runat="server"></asp:TextBox>
                </div>

            </div>
            <br />
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox CssClass="form-control" required TextMode="Password" ID="txtConfirmarSenha" placeholder="Confirme sua senha" runat="server"></asp:TextBox>
                    <asp:CompareValidator CssClass="label label-warning" ID="CompareValidatorConfirmarSenha" runat="server" ErrorMessage="As Senhas não batem" ControlToCompare="txtSenha" ControlToValidate="txtConfirmarSenha"></asp:CompareValidator>
                </div>


            </div>
            <br />
            <div class="row">
                <div class="col col-sm-3">
                    <asp:DropDownList CssClass="form-control" ID="dropdownStatus" runat="server"></asp:DropDownList>
                </div>

            </div>
            <br />
            <asp:Button CssClass="btn btn-primary" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </div>
    </div>
    <div class="panel panel-primary">
        <div class="panel-heading">Usuários cadastrados</div>
        <div class="panel-body">
            <%
                PreencherGridUsuarios();
                %>
            
            <%--<asp:GridView CssClass="table table-hover" ID="gridUsuarios" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField DataField="id_usuario" HeaderText="#"></asp:BoundField>
                    <asp:BoundField DataField="nome_usuario" HeaderText="Nome"></asp:BoundField>
                    <asp:BoundField DataField="login_usuario" HeaderText="Login"></asp:BoundField>
                    <asp:BoundField DataField="Status.descricao_status" HeaderText="Status"></asp:BoundField>
                    <asp:BoundField DataField="" HeaderText=<%%></asp:BoundField>
                </Columns>
            </asp:GridView>--%>
        </div>
    </div>

    <div>
        
    </div>
</asp:Content>
