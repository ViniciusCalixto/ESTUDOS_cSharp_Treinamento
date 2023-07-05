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
            if (!IsPostBack)
            {
                Session.Clear();
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                Usuario usuario = contexto.Usuario.Where(u => u.login_usuario == txtUserName.Text
                                                            && u.senha_usuario == txtPassword.Text && u.status_usuario == 1).FirstOrDefault();

                if (usuario != null)
                {
                    Session["USUARIO_LOGADO"] = usuario; //armazenar os dados na sessão
                                                         //Redirecionamento
                                                         //Response.Redirect("~/Default.aspx");

                    //Redirecionamento passando parametros via QueryString
                    //Response.Redirect("~/Default.aspx?id=" + usuario.id_usuario); passar um parametro via querystring

                    //Passar mais de um parametro via querystring
                    //Response.Redirect("~/Default.aspx?id=" + usuario.id_usuario + "&nome=" + usuario.login_usuario);

                    //Redirecionar para a pagina principal
                    Response.Redirect("~/WebForms/Home.aspx");
                }
                else
                {
                    lblMensagem.Text = "Usuário/Senha inválido ou sem permissão";
                }
            }
        }
    }
}