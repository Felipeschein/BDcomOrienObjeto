using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDOrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Banco("DESKTOP-IMST3LM\\SQLEXPRESS", "DBLICKOSKITEACHER");

            var listaDeNomes = new List<string>();
            listaDeNomes.Add("Tiago Lucca");
            listaDeNomes.Add("Jeferson");
            listaDeNomes.Add("Bruno");
            listaDeNomes.Add("Silas");
            listaDeNomes.Add("Leticia");

            foreach (var item in listaDeNomes)
            {
                banco.ExecutarComando("insert into PessoasNome(nome) values('" + item + "')");
            }

            
        }
    }
}
