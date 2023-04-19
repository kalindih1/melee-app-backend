using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Melee_percent_app.Models
{
    public class KillPercent
    {
       

        [Required]

        public int Val { get; set; }



        [Key]

        [Required]

        public int Id { get; set; }


        

        [Required]

        public int MeleeCharacterId { get; set; }


      

        [Required]

        public int MeleeStageId { get; set; }



      
    }
}
