using NUnit.Framework;
using RpgGame;

namespace RpgGameTest
{
    public class CharacterStatsCalculatorTest
    {
        private const int BaseDefense = 10;

        [Test]
        public void IsWearingNoEquipment_HasBaseDefense()
        {
            var totalDefense = CharacterStatsCalculator.CalculateDefense();

            Assert.AreEqual(BaseDefense, totalDefense);
        }

        //[TestMethod]
        public void IsWearingTop_HasTopAndBaseDefense()
        {
            var totalDefense = CharacterStatsCalculator.CalculateDefense();

            Assert.AreEqual(BaseDefense, totalDefense);
        }
    }
}