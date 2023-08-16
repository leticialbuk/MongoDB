using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    internal class ListandoDocs
    {
        static void Main(string[] args)
        {
            Task T = MainSync(args);
            Console.WriteLine("Precione ENTER");
            Console.ReadLine();
        }

        static async Task MainSync(string[] args)
        {
                var conexaoLivros = new DbContext();
                Console.WriteLine("Listando Livros");

                var listaLivros = await conexaoLivros.Livros.Find(new BsonDocument()).ToListAsync();
                foreach (var doc in listaLivros)
                    Console.WriteLine(doc.ToJson<Livro>());

                Console.WriteLine("Fim da lista");
        }
    }
}
