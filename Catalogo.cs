using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study_aspnet
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros() {
            var livros = new List<Livro>();

            livros.Add(new Livro("001", "Livro 01", 10.00m));
            livros.Add(new Livro("002", "Livro 02", 11.00m));
            livros.Add(new Livro("003", "Livro 03", 12.00m));

            return livros;
        }
    }
}
