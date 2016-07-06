using System;

namespace TextAdventureClases.Creatures
{
    public class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }

        #region Creature Constructors
        public Creature()
        {
            Name = "Unknown Creature";
            Health = 100;
            Level = 1;
            Strength = 1;
            Defense = 1;
        }

        public Creature(string name)
        {
            Name = name;
            Health = 100;
            Level = 1;
            Strength = 1;
            Defense = 1;
        }

        public Creature(string name, int health, int level, int strength, int defense)
        {
            Name = name;
            Health = health;
            Level = level;
            Strength = strength;
            Defense = defense;
        }
        #endregion
        #region Health Methods
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
        #endregion
        #region Level Methods
        public int LevelUp()
        {
            return ++Level;
        }
        #endregion
        #region Strength Methods
        public int GainStrength(int newStrength)
        {
            Strength = Strength + newStrength;
            return Strength;
        }
        #endregion
        #region Defense Methods
        public int GainDefense(int newDefense)
        {
            Defense = Defense + newDefense;
            return Defense;
        }
        #endregion
    }
}
