using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Seja bem vindo, " + ((Usuario)Session["USUARIO_LOGADO"]).nome_usuario; //Capturando a session

            //Capturar a querystring
            lblMensagemQueryString.Text = "ID DO USUÁRIO: " + Request.QueryString.Get("id") + " / LOGIN DO USUÁRIO: " + Request.QueryString.Get("nome");

            //Remover Sessão
            Session.Remove("USUARIO_LOGADO");
        }
    }
}