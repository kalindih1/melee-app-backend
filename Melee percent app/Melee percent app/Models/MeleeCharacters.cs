using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Melee_percent_app.Models
{
    public class MeleeCharacters
    {
        [Key]

        [Required]

        public int CharacterID { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Character Name")]

        public string Name { get; set; }

    }
}
