namespace KingdomOfRelationships.Models
{
    public class CharacterRelationships
    {
        public int CharacterRelationshipsId { get; set; }
        public int ParentCharacterId { get; set; }
        public int RelationshipId { get; set; }
        public int ChildCharacterId { get; set; }

    }
}