using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopWeb.WebForms
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PreencherComboStatus();
                //PreencherGridUsuarios();
                if (!string.IsNullOrEmpty(Request.QueryString.Get("id")))
                {
                    if(!string.IsNullOrEmpty(Request.QueryString.Get("acao")))
                    {
                        Deletar(Convert.ToInt32(Request.QueryString.Get("id")));
                    }
                    AtualizacaoUsuario(Convert.ToInt32(Request.QueryString.Get("id")));

                }
            }

        }

        private void Deletar(int idUsuario)
        {
            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                Usuario usuario = contexto.Usuario.Where(u => u.id_usuario == idUsuario).FirstOrDefault();

                contexto.Usuario.Remove(usuario);
                contexto.SaveChanges();
                Response.Redirect("~/WebForms/CadastroUsuario");
            }
        }
        private void AtualizacaoUsuario(int idUsuario)
        {
            using (DBPetShopEntities cx = new DBPetShopEntities())
            {
                Usuario usuario = cx.Usuario.Where(u => u.id_usuario == idUsuario).FirstOrDefault();

                txtNome.Text = usuario.nome_usuario;
                txtLogin.Text = usuario.login_usuario;
                dropdownStatus.SelectedValue = usuario.status_usuario.ToString();

            }
        }

        public void PreencherGridUsuarios()
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;

            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                List<Usuario> listaDeUsuario = contexto.Usuario.ToList();

                //gridUsuarios.DataSource = listaDeUsuario;
                //gridUsuarios.DataBind();
                Response.Write("<table class='table table-hover'>");
                Response.Write("<thead>");
                Response.Write("<tr>");
                Response.Write("<th>#</th>");
                Response.Write("<th>Nome</th>");
                Response.Write("<th>Login</th>");
                Response.Write("<th>Status</th>");
                Response.Write("<th></th>");
                Response.Write("<th></th>");
                Response.Write("</tr></thead><tbody>");
                foreach (var item in listaDeUsuario)
                {
                    Response.Write("<tr>");
                    Response.Write("<td>" + item.id_usuario + "</td>");
                    Response.Write("<td>" + item.nome_usuario + "</td>");
                    Response.Write("<td>" + item.login_usuario + "</td>");
                    Response.Write("<td>" + item.Status.descricao_status + "</td>");
                    Response.Write("<td><button type='button' onclick=\"window.location ='" + url + "?id=" + item.id_usuario + "'\" class='btn btn-default btn-sm'>");
                    Response.Write("<span class='glyphicon glyphicon-edit'></span> Editar</button></td>");
                    Response.Write("<td><button type='button' onclick=\"window.location ='" + url + "?id=" + item.id_usuario + "&acao=deletar'\" class='btn btn-default btn-sm'>");
                    Response.Write("<span class='glyphicon glyphicon-trash'></span> Excluir</button></td>");
                    Response.Write("</tr>");

                }
                Response.Write("</tbody>");
                Response.Write("</table>");
            }
        }

        private void PreencherComboStatus()
        {
            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                List<Status> listaDeStatus = contexto.Status.ToList();

                dropdownStatus.DataSource = listaDeStatus;
                dropdownStatus.DataTextField = "descricao_status";
                dropdownStatus.DataValueField = "id_status";
                dropdownStatus.DataBind();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 - preencher o objeto manipulado
            Usuario objetoUsuario = null;
            if (string.IsNullOrEmpty(Request.QueryString.Get("id")))
            {
                objetoUsuario = new Usuario();  
            }
            

            //2 - manipular a transação com o Entity Framework
            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                if (!string.IsNullOrEmpty(Request.QueryString.Get("id")))
                {
                    var id = Convert.ToInt32(Request.QueryString.Get("id"));
                    objetoUsuario = contexto.Usuario.Where(u => u.id_usuario == id).FirstOrDefault();

                   
                }

                objetoUsuario.nome_usuario = txtNome.Text;
                objetoUsuario.login_usuario = txtLogin.Text;
                objetoUsuario.senha_usuario = txtSenha.Text;
                objetoUsuario.status_usuario = Convert.ToInt32(dropdownStatus.SelectedValue);

                //Preaprar o insert
                if (objetoUsuario.id_usuario == 0)
                {
                    contexto.Usuario.Add(objetoUsuario);
                }

                //Persistir na base
                contexto.SaveChanges();
                Response.Redirect("~/WebForms/CadastroUsuario");
            }

            txtNome.Text = "";
            txtLogin.Text = "";

            // PreencherGridUsuarios();
        }
    }
}