using System.ComponentModel.DataAnnotations;

namespace KingdomOfRelationships.Models
{
    public class Relationship
    {
        public int RelationshipId { get; set; }
        
        [StringLength(255)]
        public string Description { get; set; }
    }
}