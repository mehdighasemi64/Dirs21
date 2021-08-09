using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dirs21.Models;
using Dirs21.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dirs21.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly Dirs21Service _DirsService;
        public MenuController(Dirs21Service DirsService)
        {
            _DirsService = DirsService;
        }
      
        [HttpGet("GetMenu")]
        public List<VwMenu> GetMenu()  // http://localhost:5000/Menu/GetMenu
        {
            List<VwMenu> Menu = new List<VwMenu>();
            using (var db = new Dirs21DB())
            {
                Menu = db.VwMenus.ToList();
            }
            foreach (var item in Menu)
            {
                _DirsService.CreateMenu(item);
            } 
            return Menu;
        }

        [HttpGet("MenuMongo")]
        public List<VwMenu> MenuMongo() //http://localhost:5000/Menu/MenuMongo
        {
            return _DirsService.GetMenuMongo();
        }
    }
}