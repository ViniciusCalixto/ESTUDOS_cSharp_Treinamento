using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEF
{
    public partial class ExcluirMunicipio : Form
    {
        public ExcluirMunicipio()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
                int id = Convert.ToInt32(txtIdMunicipio.Text);

                Municipio umMunicipioRetornado = contexto.Municipio.Where(m => m.IdMunicipio == id).FirstOrDefault();

                contexto.Municipio.Remove(umMunicipioRetornado);

               

                contexto.SaveChanges();

                this.Close();
            }
        }
    }
}
