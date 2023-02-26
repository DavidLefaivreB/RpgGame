using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame
{
    public class HeadEquipment
    {
        public HeadEquipment(int defence)
        {
            Defence = defence;
        }

        public int Defence { get; }
    }
}
