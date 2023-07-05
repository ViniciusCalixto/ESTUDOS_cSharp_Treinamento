<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PetDetalhes.aspx.cs" Inherits="PetShopWeb.WebForms.PetDetalhes" MasterPageFile="~/Site.Master" %>

<asp:Content ID="containerPadrao" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Autalizar Cadastro de Pet</h2>

    <div class="panel panel-primary">
        <div class="panel-heading">
            Cadastro
        </div>
        <div class="panel-body">
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox ID="txtNomePet" CssClass="form-control" required placeholder="Digite o nome do Pet" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
             <div class="row">
                 <asp:Literal ID="literalImagem" runat="server"></asp:Literal>
            </div>
            <br />
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox ID="txtDataNascimento" TextMode="Date" CssClass="form-control" placeholder="Digite a data de nascimento do Pet" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox ID="txtRacaPet" CssClass="form-control" required placeholder="Digite a raca do Pet" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col col-sm-3">
                    <asp:TextBox ID="txtTipoPet" CssClass="form-control" required placeholder="Digite o tipo do Pet" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Selecionar dono do Pet</button>
            </div>
            <br />

            <div class="row">
                <div class="col col-sm-5">
                    <label>Foto do Pet</label>
                    <asp:FileUpload CssClass="form-control" ID="FileUploadFotoPet" runat="server" />
                </div>
            </div>
            <br />
            <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </div>
    </div>

</asp:Content>
