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
            //Select * from: trazer todos os registros  da tabela
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
               
                List<Estado> listaEstado = contexto.Estado.ToList();
                gridEstados.DataSource = listaEstado;
            }

        }

        private void btnTrazerOPrimeiro_Click(object sender, EventArgs e)
        {
            //Select top 1 * from : trazer o primeiro registro encontrado na tabela
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
                
                Estado umEstado = contexto.Estado.FirstOrDefault();

                List<Estado> listaEstado = new List<Estado>(); //Inicializando a lista
                listaEstado.Add(umEstado);


                gridEstados.DataSource = listaEstado;
            }
        }

        private void btnTrazerOsCincoPrimeiros_Click(object sender, EventArgs e)
        {
            //Select top 5 * from Trazer os 5 primeiros registros
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
               
                List<Estado> listaEstado = contexto.Estado.Take(5).ToList();
                gridEstados.DataSource = listaEstado;
            }

        }

        private void btnTrazerCincoUltimos_Click(object sender, EventArgs e)
        {
            //Select top 5 * from: Trazer os 5 ultimos registros
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
               
                List<Estado> listaEstado = contexto.Estado.Take(5).OrderByDescending(es => es.IdEstado).ToList();
                gridEstados.DataSource = listaEstado;
            }
        }

        private void btnTrazerUltimo_Click(object sender, EventArgs e)
        {
            //Select top 1 * from: Trazer os ultimo registros
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
                
                Estado UmEstado = contexto.Estado.ToList().LastOrDefault();

                List<Estado> listaEstado = new List<Estado>();
                listaEstado.Add(UmEstado);

                gridEstados.DataSource = listaEstado;
            }
        }

        private void btnTrazerFiltrado_Click(object sender, EventArgs e)
        {
            //Select * from Estado Where
            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
               
                List<Estado> listaEstado = contexto.Estado.Where(es => es.Sigla == txtFiltro.Text.ToUpper()).ToList();
                gridEstados.DataSource = listaEstado;
            }
        }

        private void btnIncluirMunicipio_Click(object sender, EventArgs e)
        {
            FRMMunicipio formMunicipio = new FRMMunicipio();
            formMunicipio.ShowDialog();
        }
    }
}
