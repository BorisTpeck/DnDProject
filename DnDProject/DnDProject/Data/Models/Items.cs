using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDProject.Data.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Cost { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public int Amount { get; set; }

        //Add properties

        [Required]
        public bool IsEquippable { get; set; }

        public string Reach { get; set; }

        public string Damage { get; set; }

        [ForeignKey(nameof(Characters))]
        public string CharacterId { get; set; }

        public Characters Character { get; set; }





    }
}
