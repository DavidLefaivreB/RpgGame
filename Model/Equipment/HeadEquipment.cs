using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Equipment
{
    public class HeadEquipment
    {
        public HeadEquipment(string name, int defence)
        {
            Name = name;
            Defence = defence;
        }

        public string Name { get; }
        public int Defence { get; }
    }
}
