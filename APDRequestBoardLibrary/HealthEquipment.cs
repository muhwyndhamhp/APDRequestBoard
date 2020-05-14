using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{
    public class HealthEquipment
    {
        
        public HealthEquipment(int category, int equipmentCount)
        {
            Category = category;
            EquipmentCount = equipmentCount;
        }

        public HealthEquipment(int id, int category, int equipmentCount, int personId)
        {
            Id = id;
            Category = category;
            EquipmentCount = equipmentCount;
            PersonId = personId;
        }

        public int Id { get; set; }
        public int Category { get; set; }
        public int EquipmentCount { get; set; }
        public int PersonId { get; set; }
    }
}