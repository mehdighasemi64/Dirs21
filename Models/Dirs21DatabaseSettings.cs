using System;
using System.Collections.Generic;

#nullable disable

namespace Dirs21.Models
{
    public class Dirs21DatabaseSettings : IDirs21DatabaseSettings
    {
        public string DishCollectionName { get; set; }
        public string VwMenuCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDirs21DatabaseSettings
    {
        public string DishCollectionName { get; set; }
        public string VwMenuCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

}