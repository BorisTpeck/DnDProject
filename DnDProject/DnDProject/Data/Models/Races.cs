using System.ComponentModel.DataAnnotations;

namespace DnDProject.Data.Models
{
    public class Races
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        // list of features and ASIs

     


    }
}
