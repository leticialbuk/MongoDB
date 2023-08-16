using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    public class UsandoValoresLivros
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

            Livro livro = new Livro();
            livro = valoresLivro.incluindoValoresLivro("Star Wars", "Timothy", 2010, 245, "Ficção cientifica, Ação");
            await conexaoLivros.Livros.InsertOneAsync(livro);
            Livro livro2 = new Livro();
            livro2 = valoresLivro.incluindoValoresLivro("Dom Casmurro", "Machado de Assis", 1923, 188, "Romance");
            await conexaoLivros.Livros.InsertOneAsync(livro2);

            Console.WriteLine("Documentos incluidos");
        }
    }
}

