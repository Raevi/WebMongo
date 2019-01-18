using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace WebMongo.Model
{
    public class Formation
    {
        public ObjectId Id { get; set; }

        [BsonElement("cours")]
        public string Cours { get; set; }

        [BsonElement("chapitres")]
        public List<string> Chapitres { get; set; }

        [BsonElement("auteur")]
        public Auteur Auteur { get; set; }
    }
}

