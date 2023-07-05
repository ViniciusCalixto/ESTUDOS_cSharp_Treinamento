using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopWeb.WebForms
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSaudacao.Text = "Seja bem vindo à Plataforma Pet, " + ((Usuario)Session["USUARIO_LOGADO"]).nome_usuario;
        }
    }
}