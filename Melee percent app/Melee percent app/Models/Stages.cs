using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Melee_percent_app.Models
{
    public class Stages
    {
        [Key]

        [Required]

        public int StageID { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Stage Name")]

        public string StageName { get; set; }
    }
}
