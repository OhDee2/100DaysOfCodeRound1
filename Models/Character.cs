
using System.ComponentModel.DataAnnotations;

namespace KingdomOfRelationships.Models
{
    public class Character
    {
        
        public int CharacterId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
    }
}