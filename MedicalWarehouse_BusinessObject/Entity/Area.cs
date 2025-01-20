using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class Area : BaseEntity  
    {
        public ICollection<Shipment> Shipment { get; set; } = new List<Shipment>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
