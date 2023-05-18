using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public Cliente()
        {
            
        }
        public Cliente(int id)
        {
            Id = id;
        }
        public Cliente(int id, string nome, string telefone, string rg, string cpf, string endereco )
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Rg = rg;
            Cpf = cpf;

        }
    }
}
