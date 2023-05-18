using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genero
{
    public class GeneroFilmes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public GeneroFilmes()
        {

        }
        public GeneroFilmes(int id)
        {
            Id = id;
        }

        public GeneroFilmes(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
