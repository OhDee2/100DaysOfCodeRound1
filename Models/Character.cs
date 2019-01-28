
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingdomOfRelationships.Models
{
    public class Character
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CharacterId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
    }
}