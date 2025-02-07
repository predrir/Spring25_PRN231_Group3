using MedicalWarehouse_BusinessObject.Entity;
using MedicalWarehouse_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_Repository.Interface
{
    public interface IBaseRepository
    {

    }

    public interface IBaseRepository<T> : IBaseRepository where T : BaseEntity
    {
        Task AddAsync(T entity);  
        Task UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
