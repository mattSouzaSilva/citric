using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citric
{
    class Cliente
    {
        private int id_cliente { get; set; }
        private string email { get; set; }
        private string senha { get;}
        private string nome { get; set; }
        private int cpf { get; set; }
        private DateTime data_nasc { get; set; }
        private string sexo { get; set; }
        private string end { get; set; }
        private int num { get; set; }
        private string bairro { get; set; }
        private int cep { get; set; }
        private string cidade { get; set; }
        private string estado { get; set; }
        private int fone { get; set; }

    }

    class ctr_Cliente : Cliente
    {
        public Cliente create(Cliente Cl)
        {
            return Cl;
        }
        public Cliente alterar(Cliente Cl)
        {
            return Cl;
        }
        public Cliente consultar(Cliente Cl)
        {
            return Cl;
        }
        public Cliente excluir(Cliente Cl)
        {
            return Cl;
        }
    }
}
