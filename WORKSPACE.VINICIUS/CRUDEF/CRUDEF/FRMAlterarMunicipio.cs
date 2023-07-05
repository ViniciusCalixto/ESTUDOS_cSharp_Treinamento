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
            //select * from: Trazer todos os registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                List<Estado> ListaEstado = contexto.Estado.ToList();
                comboEstados.DataSource = ListaEstado;
                comboEstados.DisplayMember = "Sigla";
                comboEstados.ValueMember = "IdEstado";
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                int idMum = Convert.ToInt32((txtIDMunicipio.Text));

                Municipio umMunicipioRetornado = contexto.Municipio.Where(m => m.IdMunicipio == idMum).FirstOrDefault();

                umMunicipioRetornado.CodIBGE= txtCodIBGE.Text;
                umMunicipioRetornado.Descricao = txtDescricao.Text;
                umMunicipioRetornado.IdEstado = Convert.ToInt32(comboEstados.SelectedValue);

                contexto.SaveChanges();

                this.Close();
            }

        }
    }
}
