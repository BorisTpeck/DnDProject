using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDProject.Data.Models
{
    public class Characters
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        //stats
        [Required]
        public int Strength { get; set; }

        [Required]
        public int Dexterity { get; set; }

        [Required]
        public int Constitution { get; set; }

        [Required]
        public int Intelligence { get; set; }

        [Required]
        public int Wisdom { get; set; }

        [Required]
        public int Charisma { get; set; }

        //inventory
        public IEnumerable<Items> Items { get; set; }
        // inventory which is a list of items

        [ForeignKey(nameof(Players))]
        public string PlayerId { get; set; }

        public IdentityUser Player { get; set; }

        [Required, Range(1, 20)]
        public int Level { get; set; }
        
        // list of proficiencies
        // campaign they are a part of
        // class and it's features (maybe new class?)
    }
}
