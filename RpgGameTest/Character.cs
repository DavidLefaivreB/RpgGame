using RpgGame;

namespace RpgGameTest
{
    internal class Character
    {
        public Character()
        {
            Equipment = new EquipmentManager();
        }

        public EquipmentManager Equipment { get; }
    }
}