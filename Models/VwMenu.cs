using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

#nullable disable

namespace Dirs21.Models
{
    [BsonIgnoreExtraElements]
    public partial class VwMenu
    {
        public int DishId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string WaitTime { get; set; }
        public string WeekDay { get; set; }
        public string Available { get; set; }
        public string Breakfast { get; set; }
        public string Lunch { get; set; }
        public string Dinner { get; set; }
    }
}
