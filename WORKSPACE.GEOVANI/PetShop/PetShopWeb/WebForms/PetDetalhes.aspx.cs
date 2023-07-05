using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopWeb.WebForms
{
    public partial class PetDetalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idPet = Convert.ToInt32(Request.QueryString.Get("idPet"));

                using (DBPetShopEntities contexto = new DBPetShopEntities())
                {
                    Pet retorno = contexto.Pet.Where(p => p.id_pet == idPet).FirstOrDefault();

                    txtNomePet.Text = retorno.nome_pet;
                    txtDataNascimento.Text = Convert.ToDateTime(retorno.data_nascimento).ToShortDateString();
                    txtRacaPet.Text = retorno.raca_pet;
                    txtTipoPet.Text = retorno.tipo_pet;
                    //Response.ContentType = retorno.MIME;
                    //Response.BinaryWrite((byte[])retorno.foto_pet);
                    StringBuilder strHtml = new StringBuilder();
                    strHtml.Append("<img src=data:" + retorno.MIME + ";base64," + Convert.ToBase64String(retorno.foto_pet) + ">");

                    

                    literalImagem.Text = strHtml.ToString();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}