using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame
{
    public class CharacterStatsCalculator
    {
        public static int CalculateDefense(Character character, EquipmentManager equipmentManager)
        {
            return character.Defence + equipmentManager.TotalDefence;
        }
    }
}
