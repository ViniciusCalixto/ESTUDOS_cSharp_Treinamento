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
    public partial class FRMExcluirMunicipio : Form
    {
        public FRMExcluirMunicipio()
        {
            InitializeComponent();

        }

        private void FRMExcluirMunicipio_Load(object sender, EventArgs e)
        {
            //select * from: Trazer todos os registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                List<Municipio> ListaMunicio = contexto.Municipio.ToList();
                gridMunicipios.DataSource = ListaMunicio;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                int idMum = Convert.ToInt32((txtIDMunicipio.Text));

                Municipio umMunicipioRetornado = contexto.Municipio.Where(m => m.IdMunicipio == idMum).FirstOrDefault();
                contexto.Municipio.Remove(umMunicipioRetornado);
                contexto.SaveChanges();

                List<Municipio> ListaMunicio = contexto.Municipio.ToList();
                gridMunicipios.DataSource = ListaMunicio;
            }
           
        }
    }
}
