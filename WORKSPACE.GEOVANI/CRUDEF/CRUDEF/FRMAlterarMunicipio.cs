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
    public partial class FRMAlterarMunicipio : Form
    {
        public FRMAlterarMunicipio()
        {
            InitializeComponent();
        }

        private void FRMAlterarMunicipio_Load(object sender, EventArgs e)
        {
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
               
                List<Estado> listaEstado = contexto.Estado.ToList();

                comboEstados.DataSource = listaEstado;
                comboEstados.DisplayMember = "Sigla";
                comboEstados.ValueMember = "IdEstado";
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
                int id = Convert.ToInt32(txtIdMunicipio.Text);

                Municipio umMunicipioRetornado = contexto.Municipio.Where(m => m.IdMunicipio == id).FirstOrDefault();

                umMunicipioRetornado.CodigoIbge = txtCodIBGE.Text;
                umMunicipioRetornado.Descricao = txtDescricao.Text;
                umMunicipioRetornado.IdEstado = Convert.ToInt32(comboEstados.SelectedValue);

                contexto.SaveChanges();

                this.Close();
            }
        }
    }
}
