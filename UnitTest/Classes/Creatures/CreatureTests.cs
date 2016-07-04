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

            Assert.IsTrue(creature.Health == startHealth - damage, "Dmage Taken");
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
    }
}
