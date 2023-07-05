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
    public partial class FRMMunicipio : Form
    {
        public FRMMunicipio()
        {
            InitializeComponent();
            gridMunicipios.AutoGenerateColumns = false;
        }

        private void FRMMunicipio_Load(object sender, EventArgs e)
        {
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
               
                List<Estado> listaEstado = contexto.Estado.ToList();

                comboEstados.DataSource = listaEstado;
                comboEstados.DisplayMember = "Sigla";
                comboEstados.ValueMember = "IdEstado";

                List<Municipio> listaMunicipio = contexto.Municipio.ToList();
                gridMunicipios.DataSource = listaMunicipio;     
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //Preparar o objeto
            Municipio umMunicipio = new Municipio();
            umMunicipio.CodigoIbge = txtCodIBGE.Text;
            umMunicipio.Descricao = txtDescricao.Text;
            umMunicipio.IdEstado = Convert.ToInt32(comboEstados.SelectedValue);

            //Incluir o objeto no Entity
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
                contexto.Municipio.Add(umMunicipio);
                //Commit na base
                contexto.SaveChanges();

                List<Municipio> listaMunicipio = contexto.Municipio.ToList();
                gridMunicipios.DataSource = listaMunicipio;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FRMAlterarMunicipio formAlterar = new FRMAlterarMunicipio();
            formAlterar.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirMunicipio formExcluir = new ExcluirMunicipio();
            formExcluir.ShowDialog();
        }
    }
}
