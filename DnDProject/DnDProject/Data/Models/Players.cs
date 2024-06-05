using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDProject.Data.Models
{
    public class Players : IdentityUser
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public IEnumerable<Characters> Characters { get; set; }

        // list of characters
        // list of campaigns they are in
    }
}
