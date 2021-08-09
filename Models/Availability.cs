using System;
using System.Collections.Generic;

#nullable disable

namespace Dirs21.Models
{
    public partial class Availability
    {
        public int AvailabilityId { get; set; }
        public int? DayOfWeek { get; set; }
        public string Description { get; set; }
    }
}
