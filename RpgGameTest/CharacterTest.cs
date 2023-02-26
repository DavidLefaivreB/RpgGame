using NUnit.Framework;
using RpgGame;

namespace RpgGameTest
{
    public class CharacterTest
    {
        [Test]
        public void CharacterCanHaveNoEquipment()
        {
            var hero = new Character();

            Assert.IsTrue(hero.Equipment.IsEmpty());
        }
    }
}
