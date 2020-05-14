using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<HealthEquipment> Request { get; set; } = new List<HealthEquipment>();
        public List<HealthEquipment> Providing { get; set; } = new List<HealthEquipment>();

    }
}
