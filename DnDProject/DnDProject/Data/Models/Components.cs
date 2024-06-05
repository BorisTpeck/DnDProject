using System.ComponentModel.DataAnnotations;

namespace DnDProject.Data.Models
{
    public class Components
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Verbal { get; set; }

        [Required]
        public bool Somatic { get; set; }

        public string Material { get; set; }
    }
}
