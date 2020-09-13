using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDOrientacaoObjeto
{
    public class Banco
    {
        private SqlConnection _banco { get; set; }  //toda propriedade privada dentro de uma classe deve iniciar com _ 

        public Banco(string nomeServidor, string nomeBancodeDados)
        {
            _banco = new SqlConnection("Server=" + nomeServidor + ";Database=" + nomeBancodeDados + "; Integrated Security=True;");
            _banco.Open();
        }
        //método público inicia com maíuscula e com verbo de ação
        public void ExecutarComando(string comandoTexto)
        {
            var comando = new SqlCommand(comandoTexto, _banco);
            comando.ExecuteNonQuery();
        }

    }
}
