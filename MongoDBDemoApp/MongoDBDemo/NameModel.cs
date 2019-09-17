using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBDemo
{
    public class NameModel
    {
        [BsonId] // map Id as _id in MongoDB
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}