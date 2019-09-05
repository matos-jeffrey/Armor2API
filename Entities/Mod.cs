using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Armor2BuildAPI.Entities
{
    [Table("Mods")]
    public class Mod
    {
        [Key]
        public int ModID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Armor")]
        public string Armor { get; set; }

        [Required]
        [Display(Name = "Affinity")]
        public string Affinity { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int Cost { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }
    }
}
