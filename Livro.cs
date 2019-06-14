using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study_aspnet
{
    public class Livro
    {
        public Livro(string codigo, string name, decimal preco)
        {
            Codigo = codigo;
            Name = name;
            Preco = preco;
        }

        public string Codigo { get; set; }
        public string Name { get; set; }
        public decimal Preco { get; set; }
    }
}
