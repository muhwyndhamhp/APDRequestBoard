using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{
    class APDDetails
    {
        public APDDetails(string equipmentName, string equippmentDescription, string equipmentImage)
        {
            EquipmentName = equipmentName;
            EquippmentDescription = equippmentDescription;
            EquipmentImage = equipmentImage;
        }

        public string EquipmentName { get; set; }
        public string EquippmentDescription { get; set; }
        public string EquipmentImage { get; set; }
    }
}
