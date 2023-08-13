using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MongoDB
{
    internal class ManipulandoClasses
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

            // acesso ao servidor
            string stringConnection = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(stringConnection);

            // acesso ao banco 
            IMongoDatabase mongoDatabase = client.GetDatabase("MongoEstudo");

            // acesso a coleção
            IMongoCollection<Livro> colecao = mongoDatabase.GetCollection<Livro>("Livros");

            // incluindo documento
            await colecao.InsertOneAsync(livro);
            Console.WriteLine("Documento incluido");
        }

    }
}
