using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PontoWeb
{
    public class AcessoDados
    {
        public static string StringConnection = Properties.Settings.Default.ControlePontoStrringConexao;
       
        public static SqlConnection Conexao = new SqlConnection(StringConnection);

        /// <summary>
        /// Método responsavel por abrir a conexao com o BD.
        /// </summary>
        public static void AbrirConexaoBd()
        {
            if(Conexao.State == ConnectionState.Closed)
            {
                Conexao.Open();
            }
        }
        /// <summary>
        /// Método responsavel por fechar a conexao com o BD.
        /// </summary>
        public static void FecharConexaoBd()
        {
            if(Conexao.State == ConnectionState.Open)
            {
                Conexao.Close();
            }
        }

    }
}