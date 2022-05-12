using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern.RealWorld
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character = null;
            if(characters.ContainsKey(key))
            {
                character = characters[key];
            }
            else
            {
                switch(key)
                {
                    case 'A':
                        character = new CharacterA();
                        break;
                    case 'B':
                        character = new CharacterB();
                        break;
                    //...
                    case 'Z':
                        character = new CharacterZ();
                        break;
                }
                characters.Add(key, character);
            }
            return character;
        }
    }
}
