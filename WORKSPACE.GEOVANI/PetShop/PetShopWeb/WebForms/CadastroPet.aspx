<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPet.aspx.cs" Inherits="PetShopWeb.WebForms.CadastroPet" MasterPageFile="~/Site.Master" %>

<asp:Content ID="containerPadrao" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cadastro de Pet</h2>

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
                <div class="col col-sm-3">
                    <asp:TextBox ID="txtDataNascimento" TextMode="Date" CssClass="form-control"  placeholder="Digite a data de nascimento do Pet" runat="server"></asp:TextBox>
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
    <div class="panel panel-primary">
        <div class="panel-heading">Pets cadastrados</div>
        <div class="panel-body">
            <%
                PreencherGridPets();
                %>
        </div>
    </div>


    <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Selecao de Dono do Pet</h4>
        </div>
        <div class="modal-body">
          <p>Some text in the modal.</p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        </div>
      </div>
      
    </div>
  </div>


</asp:Content>

