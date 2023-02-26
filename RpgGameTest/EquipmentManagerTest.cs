﻿using RpgGame;
using NUnit.Framework;

namespace RpgGameTest
{
    public class EquipmentManagerTest
    {
        private static readonly BottomEquipment PinkPanty = new BottomEquipment(1);
        private static readonly BottomEquipment DenimShort = new BottomEquipment(5);
        private static readonly TopEquipment WhiteTopTank = new TopEquipment(2);
        private static readonly TopEquipment BlueBra = new TopEquipment(1);
        private static readonly HeadEquipment BikerHelmet = new HeadEquipment(7);

        private EquipmentManager equipment;

        [SetUp]
        public void SetupEquipmentManager()
        {
            equipment = new EquipmentManager();
        }

        [Test]
        public void PuttingNoEquipment_HasNoDefence()
        {
            Assert.That(equipment.TotalDefence, Is.EqualTo(0));
        }

        [Test]
        public void PuttingBottomEquipment_DefenceIsEqualToBottomDefence()
        {
            equipment.Bottom = PinkPanty;

            Assert.That(equipment.TotalDefence, Is.EqualTo(PinkPanty.Defence));
        }

        [Test]
        public void PuttingBottomAndTopEquipment_DefenceIsEqualToAllEquipmentDefence()
        {
            equipment.Bottom = PinkPanty;
            equipment.Top = WhiteTopTank;

            Assert.That(equipment.TotalDefence, Is.EqualTo(PinkPanty.Defence + WhiteTopTank.Defence));
        }

        [Test]
        public void PuttinFullEquipment_DefenceIsEqualToAllEquipmentDefence()
        {
            equipment.Bottom = DenimShort;
            equipment.Top = BlueBra;
            equipment.Head = BikerHelmet;

            Assert.That(equipment.TotalDefence, Is.EqualTo(DenimShort.Defence + BlueBra.Defence + BikerHelmet.Defence));
        }
    }
}
