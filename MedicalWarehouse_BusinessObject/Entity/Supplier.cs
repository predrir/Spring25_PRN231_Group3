using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class Supplier : BaseEntity
    {
        public string PhoneNumber {  get; set; }
        public string ContactEmail { get; set; }   
        public ICollection<Medical> Medicals { get; set; } = new List<Medical>();
        public ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    }
}
