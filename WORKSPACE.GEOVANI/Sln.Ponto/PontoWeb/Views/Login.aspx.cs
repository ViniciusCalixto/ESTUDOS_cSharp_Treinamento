using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PontoWeb.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Usuario where usuario = @login and Senha = @senha and Ativo = 1";

            SqlCommand cmd = new SqlCommand(sql, AcessoDados.Conexao);
            cmd.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());

            AcessoDados.AbrirConexaoBd();

            IDataReader dados = cmd.ExecuteReader();
            bool UsuarioValido = false;

            if(dados.Read())
            {
                UsuarioValido = true;
            }
            else
            {
                lblMensagem.Text = "Usuario /Senha invalido.";
            }

            AcessoDados.FecharConexaoBd();

            if (UsuarioValido)
                Response.Redirect("~/Views/Index.aspx");

        }
    }
}