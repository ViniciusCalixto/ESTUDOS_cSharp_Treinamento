using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEngenhariaReversa
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ModelEngenhariaReversa contexto = new ModelEngenhariaReversa())
            {
                CLIENTE objeto = new CLIENTE();
                objeto.nomeCliente = "Vinicius";
                objeto.CPF = "12314";
                objeto.DataNascimento = new DateTime(1994, 01, 16);

                contexto.CLIENTE.Add(objeto);
                contexto.SaveChanges();
            }
        }
    }
}
