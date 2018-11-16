using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brodie_Character_Project
{
    class Character
    {
        public string name;
        public int strength;
        public int dexterity;
        public int agility;
        public int speed;
        public int knowledge;

        public Character(string name, int strength, int dexterity, int agility, int speed, int knowledge)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.agility = agility;
            this.speed = speed;
            this.knowledge = knowledge;
        }
    }

}
