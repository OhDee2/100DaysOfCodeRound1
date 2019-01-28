using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KingdomOfRelationships.Models;

namespace KingdomOfRelationships
{
    public class CharacterViewModel
    {
        public Character Character { get; set; }
        public List<Character> RelatedCharacters { get; set; }
    }
}