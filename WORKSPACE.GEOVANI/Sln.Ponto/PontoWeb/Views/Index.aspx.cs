using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PontoWeb.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            bool arquivoOK = false;

            string caminho = Server.MapPath("~/ArquivosTxt/");

            if (FileUploadTxt.HasFile)
            {
                string extensaoArquivo = Path.GetExtension(FileUploadTxt.FileName).ToLower();

                string[] extensaoPermitida = { ".txt" };

                for (int i = 0; i < extensaoPermitida.Length; i++)
                {
                    if (extensaoArquivo == extensaoPermitida[i])
                    {
                        arquivoOK = true;
                    }
                }
            }

            if (arquivoOK)
            {
                try
                {
                    FileUploadTxt.PostedFile.SaveAs(caminho + FileUploadTxt.FileName);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}