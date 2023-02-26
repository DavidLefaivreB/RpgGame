using Model.Equipment;
using System.Collections.Generic;

namespace Persistence
{
    public interface EquipmentRepository
    {
        public List<TopEquipment> loadTopEquipments();
    }
}
