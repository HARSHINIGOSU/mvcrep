using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppCore.Models;

namespace WebAppCore.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            List<Player> lstPlayers = new List<Player>
            {
                new Player{PId=1,PName="MSD",PAvg=56.90,PTeam="CSK"},
                new Player{PId=2,PName="Vijay",PAvg=56.90,PTeam="CSK"}, 
            };
                return View(lstPlayers);
             
        }
        
           
        
    }
}
