namespace RpgGame
{
    public class Character
    {
        private const int BaseDefence = 10;

        public Character()
        {
            Equipment = new EquipmentManager();
        }

        public EquipmentManager Equipment { get; }

        public int Defence => BaseDefence;
    }
}