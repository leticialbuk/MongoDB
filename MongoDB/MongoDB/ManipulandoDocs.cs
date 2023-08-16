using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    internal class ManipulandoDocs
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
                {"Título", "Guerra dos Tronos" }
            };
            doc.Add("Autor", "George Martin");
            doc.Add("Ano", 1999);
            doc.Add("Páginas", 856);

            var assuntoArray = new BsonArray();
            assuntoArray.Add("Fantasia");
            assuntoArray.Add("Ação");
            doc.Add("Assunto", assuntoArray);

            Console.WriteLine(doc);
        }
    }
}
