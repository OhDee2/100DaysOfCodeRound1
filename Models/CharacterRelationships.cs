using System.ComponentModel.DataAnnotations.Schema;

namespace KingdomOfRelationships.Models
{
    public class CharacterRelationships
    {
        public int CharacterRelationshipsId { get; set; }

        [ForeignKey("ParentCharacterId")]
        public Character ParentCharacter { get; set; }

        [ForeignKey("RelationshipId")]
        public Relationship Relationship { get; set; }

        [ForeignKey("ChildCharacterId")]
        public Character ChildCharacter { get; set; }

    }
}