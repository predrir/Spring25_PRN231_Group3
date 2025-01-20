using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class Medical : BaseEntity
    {
        public string TypeMedical {  get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<ShipmentDetail> ShipmentDetails { get; set; } = new List<ShipmentDetail>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
