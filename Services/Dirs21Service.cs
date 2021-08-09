using MongoDB.Driver;
using Dirs21.Models;
using System.Collections.Generic;
using System.Linq;

namespace Dirs21.Services
{
    public class Dirs21Service
    {
        private readonly IMongoCollection<VwMenu> _Menu;

        public Dirs21Service(IDirs21DatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _Menu = database.GetCollection<VwMenu>("Menu");

        }
        public List<VwMenu> GetMenuMongo()
        {
            List<VwMenu> Menu = new List<VwMenu>();
            Menu = _Menu.Find(menu => true).ToList();
            return Menu;
        }             
        public VwMenu CreateMenu(VwMenu MenuItme)
        {
            _Menu.InsertOne(MenuItme);
            return MenuItme;
        }
    }
}
