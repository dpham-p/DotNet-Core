using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBDemo
{
    public class PersonModel
    {
        [BsonId] // map Id as _id in MongoDB
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }
        [BsonElement("dob")] // map DateOfBirth as dob in MongoDB
        public DateTime DateOfBirth { get; set; }   
    }
}