using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextAdventureClases.Creatures;

namespace UnitTest.Classes.Creatures
{
    [TestClass]
    public class CreatureTests
    {
        [TestMethod]
        public void CanTakeDamage()
        {
            var creature = new Creature();
            int damage = 10;
            int startHealth = creature.Health;
            creature.TakeDamage(damage);

            Assert.IsTrue(creature.Health == (startHealth - damage), "Dmage Taken");
        }

        [TestMethod]
        public void CanHeal()
        {
            var creature = new Creature();
            int startHealth = creature.Health;
            int healed = creature.Heal(1, 10);

            Assert.IsTrue(healed > 0, "Healed more than 0 hp.");
            Assert.IsTrue(creature.Health > startHealth, "Health Increased");
        }

        [TestMethod]
        public void CanLevelUp()
        {
            var creature = new Creature();
            int startLevel = creature.Level;
            int newLevel = creature.LevelUp();

            Assert.IsTrue(newLevel > startLevel, "Level increased");
            Assert.IsTrue((newLevel - startLevel) == 1);
        }

        [TestMethod]
        public void CanGainStrength()
        {
            var creature = new Creature();
            int startStrength = creature.Strength;
            int newStrength = 2;
            int afterStrength = creature.GainStrength(newStrength);

            Assert.IsTrue(afterStrength > startStrength, "Strength increased");
            Assert.IsTrue((afterStrength - startStrength) == newStrength);
        }

        [TestMethod]
        public void CanGainDefense()
        {
            var creature = new Creature();
            int startDefense = creature.Defense;
            int newDefense = 2;
            int afterDefense = creature.GainDefense(newDefense);

            Assert.IsTrue(afterDefense > startDefense, "Defense increased");
            Assert.IsTrue((afterDefense - startDefense) == newDefense);
        }
    }
}
