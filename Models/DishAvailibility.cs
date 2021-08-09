using System;
using System.Collections.Generic;

#nullable disable

namespace Dirs21.Models
{
    public partial class DishAvailibility
    {
        public int DishAvailibilityId { get; set; }
        public int? AvailibilityId { get; set; }
        public int? DishId { get; set; }
        public bool? Breakfast { get; set; }
        public bool? Lunch { get; set; }
        public bool? Dinner { get; set; }
        public bool? Deactive { get; set; }
    }
}
