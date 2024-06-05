using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDProject.Data.Models
{
    public class Campaigns
    {
        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }

        public Players Player { get; set; }
        // one player is the dm

        [Required]
        public IEnumerable<Characters> Characters { get; set; }
        // list of characters in the campaign


        // list of players in the campaign
    }
}
