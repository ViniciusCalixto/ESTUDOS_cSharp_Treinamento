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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRMMunicipio_Load(object sender, EventArgs e)
        {
            //select * from: Trazer todos os registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                List<Estado> ListaEstado = contexto.Estado.ToList();
                comboEstados.DataSource = ListaEstado;
                comboEstados.DisplayMember = "Sigla";
                comboEstados.ValueMember = "IdEstado";


                List<Municipio> ListaMunicio = contexto.Municipio.ToList();

                
                gridMunicipios.DataSource = ListaMunicio;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            //preparar o objeto 
            Municipio umMunicipio = new Municipio();

            umMunicipio.CodIBGE = txtCodIBGE.Text;
            umMunicipio.Descricao = txtDescricao.Text;
            umMunicipio.IdEstado = Convert.ToInt32(comboEstados.SelectedValue);


            //insert  no municipio
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                contexto.Municipio.Add(umMunicipio);
                //commit na base 
                contexto.SaveChanges();
                List<Municipio> ListaMunicio = contexto.Municipio.ToList();
                gridMunicipios.DataSource = ListaMunicio;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FRMAlterarMunicipio frmAlterarMunicipio = new FRMAlterarMunicipio();
            frmAlterarMunicipio.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FRMExcluirMunicipio FRMExcluirMunicipio = new FRMExcluirMunicipio();
            FRMExcluirMunicipio.ShowDialog();
        }
    }
}
