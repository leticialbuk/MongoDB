using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    internal class AcessoMongo
    {
        static void Main(string[] args)
        {
            Task T = MainSync(args);
            Console.WriteLine("Precione ENTER");
            Console.ReadLine();
        }
        static async Task MainSync(string[] args)
        {
            var doc = new BsonDocument
            {
                {"Título", "Lado bom da vida" }
            };
            doc.Add("Autor", "Matthew Quick");
            doc.Add("Ano", 2012);
            doc.Add("Páginas", 256);

            var assuntoArray = new BsonArray(); 
            assuntoArray.Add("  Romance");
            assuntoArray.Add("Drama");
            doc.Add("Assunto", assuntoArray);

            Console.WriteLine(doc);

            // acesso ao servidor
            string stringConnection = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(stringConnection);

            // acesso ao banco 
            IMongoDatabase mongoDatabase = client.GetDatabase("Biblioteca");

            // acesso a coleção
            IMongoCollection<BsonDocument> colecao = mongoDatabase.GetCollection<BsonDocument>("Livros");

            // incluindo documento
            await colecao.InsertOneAsync(doc);
            Console.WriteLine("Documento incluido");
        }
    }
}
