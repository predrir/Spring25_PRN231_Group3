using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
