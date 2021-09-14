using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string bairro, string complemento, string cep, string cidade, string estado)
        {

            Lograouro = logradouro.ValidaStringVazia();
            Bairro = bairro.ValidaStringVazia();
            Complemento = complemento.ValidaStringVazia();
            CEP = cep.ValidaStringVazia();
            Cidade = cidade.ValidaStringVazia();
            Estado = estado.ValidaStringVazia();

        }
        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        
    }
}
