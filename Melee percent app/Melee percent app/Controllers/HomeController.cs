using Melee_percent_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Melee_percent_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Index()
        {
            List<MeleeCharacters> result = GetMeleeCharacters();

            return View(result);
        }

        [HttpGet]

        //get melee characterid, get meleestageid, get kill% and return kill% 
        public int GetKillPercent(string MeleeCharacter, string MeleeStage)
        {
            
            using (MeleeDbContext context = new MeleeDbContext())
            {

                 //int killPercent = new KillPercents();
                
                //get melee character id from meleecharter class

                var MeleeCharacterId = context.MeleeCharacters.Single(x => x.Name == MeleeCharacter).CharacterID;
                var StageId = context.MeleeStages.Single(x => x.StageName == MeleeStage).StageID;


                var KillPercent = context.KillPercent.Single(x => x.MeleeStageId == StageId && x.MeleeCharacterId == MeleeCharacterId).Val;

                //make if statement for if character = stage return %??

                return KillPercent ;
                

            }
           
        }

        [HttpGet]
        public List<MeleeCharacters>GetMeleeCharacters()
        {
            List<MeleeCharacters> result = null;
            using (MeleeDbContext context = new MeleeDbContext())
            {
                result = context.MeleeCharacters.ToList();
            }
            return result;
        }

        [HttpGet]

        public List<Stages>GetStages()
        {
            List<Stages> result = null;
            using (MeleeDbContext context = new MeleeDbContext())
            {
                result = context.MeleeStages.ToList();
            }
            return result;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
