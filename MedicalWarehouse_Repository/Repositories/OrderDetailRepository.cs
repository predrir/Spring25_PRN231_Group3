using MedicalWarehouse_BusinessObject.Contract;
using MedicalWarehouse_BusinessObject.Entity;
using MedicalWarehouse_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_Repository.Repositories
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
