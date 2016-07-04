using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureClases.Creatures
{
    public class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Creature()
        {
            Name = "Unknown Creature";
            Health = 100;
        }

        public Creature(string name)
        {
            Name = name;
            Health = 100;
        }

        public Creature(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health = Health - damage;
        }
        
        public int Heal(int min, int max)
        {
            int healed = new Random().Next(min, max);
            Health = Health + healed;
            return healed;
        }
    }
}
