using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KingdomOfRelationships.Models;

namespace KingdomOfRelationships
{
    public class CharacterRelationshipsViewModel
    {
        public List<Character> Characters { get; set; }
        public List<Relationship> Relationships { get; set; }
        public int SelectedParentCharacter { get; set; }
        public int SelectedChildCharacter { get; set; }
        public int SelectedRelationship { get; set; }
    }
}