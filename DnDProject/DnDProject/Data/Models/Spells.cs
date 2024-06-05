using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDProject.Data.Models
{
    public class Spells
    {
        [Required]
        public string Name { get; set; }

        [Required, Range(0, 9)]
        public int Level { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey(nameof(Components))]
        public int ComponentsId { get; set; }

        [Required]
        public Components Components { get; set; }
        
        [Required]
        public string Duration { get; set; }

        [Required]
        public string CastingTime { get; set; }

        public string Damage { get; set; }


    }
}
