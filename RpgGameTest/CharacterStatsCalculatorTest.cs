using NUnit.Framework;
using RpgGame;

namespace RpgGameTest
{
    public class CharacterStatsCalculatorTest
    {
        Character character;
        EquipmentManager equipmentManager;

        [SetUp]
        public void SetUp()
        {
            character = new Character();
            equipmentManager = new EquipmentManager();
        }

        [Test]
        public void IsWearingNoEquipment_HasBaseDefense()
        {
            var totalDefense = CharacterStatsCalculator.CalculateDefense(character, equipmentManager);

            Assert.That(totalDefense, Is.EqualTo(character.Defence));
        }

        [Test]
        public void IsWearingTop_HasTopAndBaseDefense()
        {
            equipmentManager.Top = new TopEquipment(4);

            var totalDefense = CharacterStatsCalculator.CalculateDefense(character, equipmentManager);

            Assert.That(totalDefense, Is.EqualTo(character.Defence + equipmentManager.TotalDefence));
        }
    }
}