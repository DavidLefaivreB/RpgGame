using RpgGame;
using NUnit.Framework;

namespace RpgGameTest
{
    public class EquipmentManagerTest
    {
        private static readonly BottomEquipment PinkPanty = new BottomEquipment(3);
        private static readonly TopEquipment WhiteTopTank = new TopEquipment(2);

        private static readonly EquipmentManager equipment = new EquipmentManager();

        [Test]
        public void EmptyEquipment_HasNoDefence()
        {
            Assert.That(equipment.TotalDefence, Is.EqualTo(0));
        }

        [Test]
        public void BottomEquipment_DefenceIsEqualToBottomDefence()
        {
            equipment.Bottom = PinkPanty;

            Assert.That(equipment.TotalDefence, Is.EqualTo(PinkPanty.Defence));
        }

        [Test]
        public void BottomAndTopEquipment_DefenceIsEqualToAllEquipmentDefence()
        {
            equipment.Bottom = PinkPanty;
            equipment.Top = WhiteTopTank;

            Assert.That(equipment.TotalDefence, Is.EqualTo(PinkPanty.Defence + WhiteTopTank.Defence));
        }
    }
}
