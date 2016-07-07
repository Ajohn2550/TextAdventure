using System;

namespace TextAdventureClases.Creatures
{
    public class Creature
    {
        private int maxHealth = 100;

        public string Name { get; private set; } = "Unknown Creature";
        public int Health { get; private set; } = 100;
        public int Level { get; private set; } = 1;
        public int Strength { get; private set; } = 1;
        public int Defense { get; private set; } = 1;

        #region Creature Constructors
        public Creature() { }

        public Creature(string name)
        {
            Name = name;
        }

        public Creature(string name, int health, int level, int strength, int defense)
        {
            Name = name;
            Health = health;
            maxHealth = health;
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
        
        public int GainHealthPoints(int hp)
        {
            return maxHealth += hp;
        }

        public int Heal(int min, int max)
        {
            int newHealth = new Random().Next(min, max) + Health;
            int oldHealth = Health;

            if (newHealth > maxHealth)
            {
                Health = maxHealth;
                return maxHealth - oldHealth;
            }
            else
            {
                Health += newHealth;
                return newHealth;
            }
        }
        #endregion
        #region Level Methods
        public int LevelUp()
        {
            return ++Level;
        }
        #endregion
        #region Strength Methods
        public int GainStrength()
        {
            return ++Strength;
        }

        public int GainStrength(int newStrength)
        {
            Strength = Strength + newStrength;
            return Strength;
        }
        #endregion
        #region Defense Methods
        public int GainDefense()
        {
            return ++Defense;
        }

        public int GainDefense(int newDefense)
        {
            Defense = Defense + newDefense;
            return Defense;
        }
        #endregion
    }
}
