using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame
{
    public class EquipmentManager
    {
        public int TotalDefence => (Bottom != null ? Bottom.Defence : 0) + (Top != null ? Top.Defence : 0);

        public BottomEquipment? Bottom { get; set; }
        public TopEquipment Top { get; set; }

        public bool IsEmpty()
        {
            return true;
        }
    }
}
