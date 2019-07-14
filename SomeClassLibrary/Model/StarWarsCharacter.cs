using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeClassLibrary.Model
{
    public enum GenderType {  Male, Female, Robot }

    public class StarWarsCharacter
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Mass { get; set; }
        public string HairColour { get; set; }
        public string BirthYear { get; set; }
        public GenderType Gender { get; set; }

        public StarWarsCharacter( string name, int height, int mass, string hair, string birthYear, GenderType g)
        {
            Name = name; Height = height; Mass = mass; HairColour = hair; BirthYear = birthYear; Gender = g;
        }
    }
}
