using Model.Equipment;
using System;
using System.Collections.Generic;

namespace Persistence
{
    public class InMemoryEquipmentRepository : EquipmentRepository
    {
        public List<TopEquipment> loadTopEquipments()
        {
            List<TopEquipment> topEquipments = new List<TopEquipment>();
            topEquipments.Add(new TopEquipment("Topless", 0));
            topEquipments.Add(new TopEquipment("Blue Bra", 1));

            return topEquipments;
        }
    }
}
