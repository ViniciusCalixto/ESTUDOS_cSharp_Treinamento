using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopWeb.WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                usuario usuario = contexto.usuario.Where(u => u.login_usuario == txtUsername.Text
                                                            && u.senha_usuario == txtPassword.Text
                                                            && u.status_usuario == 1).FirstOrDefault();
                if (usuario != null)
                {
                    //criar uma sessao chamada USUARIO_LOGADO que irá armazenar o Usuario.
                    Session["USUARIO_LOGADO"] = usuario;

                    //redirecionamento para outro pagina
                    //Response.Redirect("~/Default.aspx");

                    //redirecionamento passando parametros via querystring

                    // passar apenas 1 parametro via query string 
                    //Response.Redirect("~/Default.aspx?id=" + usuario.id_usuario);
                    
                    //para passar mais de 1 parametro utilizar o "&".
                    Response.Redirect("~/Default.aspx?id=" + usuario.id_usuario + "&nome=" +usuario.login_usuario);
                }
                else
                {
                    lblMensagem.Text = "Usuário/Senha inválido ou sem permissão";
                }
            }

        }
    }
}