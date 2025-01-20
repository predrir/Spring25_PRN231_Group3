using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Order Orders { get; set; }
        public Guid MedicalId { get; set; }
        public Medical Medical { get; set; }
        public Guid ShipmentId { get; set; }
        public Shipment Shipment { get; set; }
        public int Quantity { get; set; }
    }
}
