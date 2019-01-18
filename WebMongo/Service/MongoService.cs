using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using WebMongo.Model;

namespace WebMongo.Service
{
    public class MongoService
    {
        private readonly IMongoCollection<Formation> _formations;

        public MongoService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("TestDb"));
            var database = client.GetDatabase("Test");
            _formations = database.GetCollection<Formation>("test");
        }

        public List<Formation> Get()
        {
            return _formations.Find(book => true).ToList();
        }

        public Formation Get(string id)
        {
            var docId = new ObjectId(id);

            return _formations.Find<Formation>(book => book.Id == docId).FirstOrDefault();
        }

        public Formation Create(Formation book)
        {
            _formations.InsertOne(book);
            return book;
        }

        public void Update(string id, Formation bookIn)
        {
            var docId = new ObjectId(id);

            _formations.ReplaceOne(book => book.Id == docId, bookIn);
        }

        public void Remove(Formation bookIn)
        {
            _formations.DeleteOne(book => book.Id == bookIn.Id);
        }

        public void Remove(ObjectId id)
        {
            _formations.DeleteOne(book => book.Id == id);
        }
    }
}
