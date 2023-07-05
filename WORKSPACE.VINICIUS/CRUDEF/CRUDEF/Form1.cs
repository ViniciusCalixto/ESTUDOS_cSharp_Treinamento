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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridEstados.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //select * from: Trazer todos os registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                List<Estado> ListaEstado = contexto.Estado.ToList();
                gridEstados.DataSource = ListaEstado;
            }
        }

        private void btnTrazerPrimeiro_Click(object sender, EventArgs e)
        {
            //select top 1 * from estado: trazer o primeiro registro encontrado na tabela 
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                Estado umEstado = contexto.Estado.FirstOrDefault(); //bucando apenas 1 registro TOP first
                List<Estado> ListaEstado = new List<Estado>(); //inicializando as Lista
                ListaEstado.Add(umEstado);
                gridEstados.DataSource = ListaEstado;

            }

        }

        private void btnTop5_Click(object sender, EventArgs e)
        {
            //Trazer os 5 primeiros registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                List<Estado> ListaEstado = contexto.Estado.Take(5).ToList();
                gridEstados.DataSource = ListaEstado;
            }
        }

        private void btnTop5Utimos_Click(object sender, EventArgs e)
        {
            //Trazer os 5 ultimos registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                List<Estado> ListaEstado = contexto.Estado.Take(5).OrderByDescending(es => es.IdEstado).ToList().OrderBy(est => est.IdEstado).ToList();

                gridEstados.DataSource = ListaEstado;
            }

        }

        private void btnUtimo_Click(object sender, EventArgs e)
        {
            //Trazer o ultimo registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                Estado umEstado = contexto.Estado.ToList().LastOrDefault();

                List<Estado> ListaEstado = new List<Estado>();
                ListaEstado.Add(umEstado);

                gridEstados.DataSource = ListaEstado;
            }

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            //Trazer o ultimo registros da tabela
            using (EXEMPLO_MODELFIRSTEntities contexto = new EXEMPLO_MODELFIRSTEntities())
            {
                List<Estado> ListaEstado = contexto.Estado.Where(es => es.Sigla == txtFiltro.Text.ToUpper()).ToList();

                gridEstados.DataSource = ListaEstado;
            }

        }

        private void btnCadastrarMuni_Click(object sender, EventArgs e)
        {
            FRMMunicipio frmMunicipio = new FRMMunicipio();
            frmMunicipio.ShowDialog();
        }
    }
}
