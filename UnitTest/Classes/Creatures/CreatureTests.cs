using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextAdventureClases.Creatures;

namespace UnitTest.Classes.Creatures
{
    [TestClass]
    public class CreatureTests
    {
        [TestMethod]
        public void HasDefaults()
        {
            var creature = new Creature();
            Assert.AreEqual(creature.Name, "Unknown Creature");
            Assert.AreEqual(creature.Health, 100);
            Assert.AreEqual(creature.Level, 1);
            Assert.AreEqual(creature.Strength, 1);
            Assert.AreEqual(creature.Defense, 1);
        }

        [TestMethod]
        public void CanHaveAName()
        {
            string creatureName = "Creature Name";
            var creature = new Creature(creatureName);

            Assert.AreEqual(creature.Name, creatureName);
        }

        [TestMethod]
        public void CanHaveCustomValues()
        {
            string creatureName = "Creature Name";
            int creatureHealth = 200;
            int creatureLevel = 50;
            int creatureStrength = 25;
            int creatureDefense = 25;

            var creature = new Creature(creatureName, creatureHealth, creatureLevel, creatureStrength, creatureDefense);

            Assert.AreEqual(creature.Name, creatureName);
            Assert.AreEqual(creature.Health, creatureHealth);
            Assert.AreEqual(creature.Level, creatureLevel);
            Assert.AreEqual(creature.Strength, creatureStrength);
            Assert.AreEqual(creature.Defense, creatureDefense);
        }

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
        public void CanGainHp()
        {
            var creature = new Creature();

            Assert.IsTrue(creature.GainHealthPoints(10) > 10, "Gained Health");
        }

        [TestMethod]
        public void CanHeal()
        {
            var creature = new Creature();
            int startHealth = creature.Health;
            creature.GainHealthPoints(10);
            int healed = creature.Heal(1, 10);

            Assert.IsTrue(healed > 0, "Healed more than 0 hp.");
            Assert.IsTrue(creature.Health > startHealth, "Health Increased");
        }
        [TestMethod]
        public void HasMaxHealth()
        {
            var creature = new Creature();
            int startHealnth = creature.Health;
            int healed = creature.Heal(1000, 1001);

            Assert.IsTrue(healed == 0, "Did not increase");
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
        public void CanGainAStrength()
        {
            var creature = new Creature();
            int startStrength = creature.Strength;
            int afterStrength = creature.GainStrength();

            Assert.IsTrue((afterStrength - startStrength) == 1, "Strength increased by 1");
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
        public void CanGainADefense()
        {
            var creature = new Creature();
            int startDefense = creature.Defense;
            int afterDefense = creature.GainDefense();

            Assert.IsTrue((afterDefense - startDefense) == 1, "Strength increased by 1");
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
