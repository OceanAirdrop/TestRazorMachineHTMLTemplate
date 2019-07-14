using SomeClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeClassLibrary
{
    public static class FetchStarWarsCharacters
    {
        public static List<StarWarsCharacter> Get()
        {
            var result = new List<StarWarsCharacter>();

            result.Add(new StarWarsCharacter("Luke Skywalker", 172, 77, "blond", "19BBY", GenderType.Male));
            result.Add(new StarWarsCharacter("C-3PO", 167, 75, "n/a", "112BBY", GenderType.Robot));
            result.Add(new StarWarsCharacter("R2-D2", 96, 32, "n/a", "33BBY", GenderType.Robot));
            result.Add(new StarWarsCharacter("Darth Vader", 202, 136, "n/a", "41.9BBY", GenderType.Male));
            result.Add(new StarWarsCharacter("Leia Organa", 150, 49, "brown", "19BBY", GenderType.Female));

            return result;
        }
    }
}
