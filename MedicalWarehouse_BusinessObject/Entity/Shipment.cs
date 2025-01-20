using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class Shipment : BaseEntity
    {
        public Guid AreaId { get; set; }
        public Area Area { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime ShipDate { get; set; }
        public ICollection<ShipmentDetail> ShipmentDetails { get; set; } = new List<ShipmentDetail>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
