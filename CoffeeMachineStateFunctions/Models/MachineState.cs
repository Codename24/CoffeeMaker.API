using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CoffeeMachineStateFunctions.Models
{
    public class MachineState
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int CoffeeMachineId { get; set; }
        public int Status { get; set; }
        public bool ErrorStatus { get; set; }
        public DateTime Date { get; set; }
    }
}
