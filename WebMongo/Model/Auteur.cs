using MongoDB.Bson.Serialization.Attributes;

namespace WebMongo.Model
{
    public class Auteur
    {
        [BsonElement("nom")]
        public string Nom { get; set; }

        [BsonElement("prenom")]
        public string Prenom { get; set; }
    }
}
