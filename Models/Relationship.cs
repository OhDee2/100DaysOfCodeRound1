using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingdomOfRelationships.Models
{
    public class Relationship
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RelationshipId { get; set; }
        
        [StringLength(255)]
        public string Description { get; set; }
    }
}