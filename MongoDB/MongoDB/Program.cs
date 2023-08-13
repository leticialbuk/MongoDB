using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    public class AcessandoMongo
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
                {"Título", "Ldo bom da vida" }
            };
            doc.Add("Autor", "");
            doc.Add("Ano", 2012);
            doc.Add("Páginas", 856);

            var assuntoArray = new BsonArray();
            assuntoArray.Add("  Romance");
            assuntoArray.Add("Comédia");
            doc.Add("Assunto", assuntoArray);

            Console.WriteLine(doc);

            // acesso ao servidor
            string stringConnection = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(stringConnection);

            // acesso ao banco 
            IMongoDatabase mongoDatabase = client.GetDatabase("MongoEstudo");

            // acesso a coleção
            IMongoCollection<BsonDocument> colecao = mongoDatabase.GetCollection<BsonDocument>("Livros");

            // incluindo documento
            await colecao.InsertOneAsync(doc);
            Console.WriteLine("Documento incluido");
        }
    }
}
