using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid AreaId { get; set; }
        public Area Area { get; set; }
        public int Quantity { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public ICollection<Medical> Medicals { get; set; } = new List<Medical>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
