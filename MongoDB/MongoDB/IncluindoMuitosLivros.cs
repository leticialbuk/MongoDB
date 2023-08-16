using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    internal class IncluindoMuitosLivros
    {
        static void Main(string[] args)
        {
            Task T = MainSync(args);
            Console.WriteLine("Precione ENTER");
            Console.ReadLine();
        }

        static async Task MainSync(string[] args)
        {
            //acessando atraves da classe de conexão
            var conexaoLivros = new DbContext();

            List<Livro> Livros = new List<Livro>();
            Livros.Add(valoresLivro.incluindoValoresLivro("A dança com dragões", "George Martin", 2011, 934, "Fantasia"));
            Livros.Add(valoresLivro.incluindoValoresLivro("Senhor dos aneis", "J R R Token", 1948, 1956, "Fantasia"));
            Livros.Add(valoresLivro.incluindoValoresLivro("Saude e Sabor", "Yemos", 2012, 245, "Culinaria"));
            Livros.Add(valoresLivro.incluindoValoresLivro("Chapeuzinho Amarelo", "Chico Buarque", 2008, 123, "Infantil"));
            Livros.Add(valoresLivro.incluindoValoresLivro("Da Russia com amor", "Iam Fleming", 1966, 245, "Espionagem, Ação"));

            await conexaoLivros.Livros.InsertManyAsync(Livros);

            Console.WriteLine("Documentos incluidos");
        }
    }
}
