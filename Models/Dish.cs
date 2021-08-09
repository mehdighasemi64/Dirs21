using System;
using System.Collections.Generic;

#nullable disable

namespace Dirs21.Models
{
    public partial class Dish
    {
        public int DishId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? WaitTime { get; set; }
        public bool? Deactive { get; set; }
    }
}
