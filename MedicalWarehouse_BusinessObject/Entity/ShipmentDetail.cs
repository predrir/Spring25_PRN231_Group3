using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class ShipmentDetail : BaseEntity
    {
        public Guid ShipmentId { get; set; }
        public Shipment Shipment { get; set; }
        public Guid MedicalId { get; set; }
        public Medical Medical { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}
