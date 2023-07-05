using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopWeb.WebForms
{
    public partial class CadastroPet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            //Montar o objeto
            Pet pet = new Pet();

            pet.nome_pet = txtNomePet.Text;
            pet.data_nascimento = DateTime.Now;//Convert.ToDateTime(txtDataNascimento.Text);
            pet.data_cadastro = DateTime.Now;
            pet.raca_pet = txtRacaPet.Text;
            pet.tipo_pet = txtTipoPet.Text;
            pet.id_cliente = 2; // por enquanto manual..

            //Manipular fileupload para a foto do pet
            if(FileUploadFotoPet.PostedFile != null || !string.IsNullOrEmpty(FileUploadFotoPet.PostedFile.FileName) || FileUploadFotoPet.PostedFile.InputStream != null)
            {
                //Capturar a extensao do arquivo
                string extensao = Path.GetExtension(FileUploadFotoPet.PostedFile.FileName).ToLower();
                string tipoArquivo = "";

                switch (extensao)
                {
                    case ".gif":
                        tipoArquivo = "image/gif";
                        break;
                    case ".jpg":
                    case ".jpeg":
                    case ".jpe":
                        tipoArquivo = "image/jpeg";
                        break;
                    default:
                        //Erro
                        break;
                }

                byte[] imagem = new byte[FileUploadFotoPet.PostedFile.InputStream.Length + 1];
                FileUploadFotoPet.PostedFile.InputStream.Read(imagem, 0, imagem.Length);

                pet.foto_pet = imagem;
                pet.nome_arquivo_foto = FileUploadFotoPet.PostedFile.FileName;
                pet.MIME = tipoArquivo;
            }

            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                contexto.Pet.Add(pet);
                contexto.SaveChanges();
            }
        }

        public void PreencherGridPets()
        {
            using (DBPetShopEntities contexto = new DBPetShopEntities())
            {
                List<Pet> listaPet = contexto.Pet.ToList();

                Response.Write("<table class='table table-hover'>");
                Response.Write("<thead>");
                Response.Write("<tr>");
                Response.Write("<th>ID</th>");
                Response.Write("<th>Nome</th>");
                Response.Write("<th>Data Nascimento</th>");
                Response.Write("<th>Raca</th>");
                Response.Write("<th>Tipo</th>");
                Response.Write("<th>Dono do Pet</th>");
                Response.Write("<th></th>");
                Response.Write("<th></th>");
                Response.Write("</tr></thead><tbody>");
                string url ="http://" + HttpContext.Current.Request.Url.Authority + "/WebForms/PetDetalhes?idPet=";
                foreach (var item in listaPet)
                {
                    Response.Write("<tr>");
                    Response.Write("<td>" + item.id_pet + "</td>");
                    Response.Write("<td>" + item.nome_pet + "</td>");
                    Response.Write("<td>" + Convert.ToDateTime(item.data_nascimento).ToShortDateString() + "</td>");
                    Response.Write("<td>" + item.raca_pet + "</td>");
                    Response.Write("<td>" + item.tipo_pet + "</td>");
                    Response.Write("<td>" + item.Cliente.nome_cliente + "</td>");
                    Response.Write("<td><button type='button' onclick=\"window.location='" + url + item.id_pet + "'\"class='btn btn-default btn-sm'>");
                    Response.Write("<span class='glyphicon glyphicon-edit'></span>Editar</button></td>");
                    Response.Write("</tr>");
                }

                Response.Write("</tbody></table>");
            }
        }
    }
}