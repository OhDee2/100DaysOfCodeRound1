using System.Collections.Generic;
using KingdomOfRelationships.Models;

namespace KingdomOfRelationships.Helpers
{
    class DistinctCharacterComparer : IEqualityComparer<Character>
    {

        public bool Equals(Character x, Character y)
        {
            return x.CharacterId == y.CharacterId &&
                x.Name == y.Name;
        }

        public int GetHashCode(Character obj)
        {
            return obj.CharacterId.GetHashCode() ^
                obj.Name.GetHashCode();
        }
    }
}