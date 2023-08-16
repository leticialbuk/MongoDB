using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    public class DbContext
    {
        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_DA_BASE = "MongoEstudo";
        public const string NOME_DA_COLECAO = "Biblioteca";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static DbContext()
        {
            _client = new MongoClient(STRING_DE_CONEXAO);
            _database = _client.GetDatabase(NOME_DA_BASE);
        }

        public IMongoClient Client { get { return _client; } }
        public IMongoCollection<Livro> Livros
        {
            get { return _database.GetCollection<Livro>(NOME_DA_COLECAO); }
        }
    }
}
