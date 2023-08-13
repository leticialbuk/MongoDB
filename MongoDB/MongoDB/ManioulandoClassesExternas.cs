using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    class ManioulandoClassesExternas
    {
        static void Main(string[] args)
        {
            Task T = MainSync(args);
            Console.WriteLine("Precione ENTER");
            Console.ReadLine();
        }

        static async Task MainSync(string[] args)
        {
            Livro livro = new Livro();
            livro.Titulo = "Sob redonda";
            livro.Autor = "Stepaahn King";
            livro.Ano = 2012;
            livro.Paginas = 679;

            List<string> listaAssuntos = new List<string>();
            listaAssuntos.Add("Ficação Cientifica");
            listaAssuntos.Add("Terror");
            listaAssuntos.Add("Ação");
            livro.Assunto = listaAssuntos;

            //acessando atraves da classe de conexão
            var conexaoLivros = new ConnectionMongo();

            await conexaoLivros.Livros.InsertOneAsync(livro);
            Console.WriteLine("Documento incluido");
        }
    }
}
