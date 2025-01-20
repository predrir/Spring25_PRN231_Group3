using MedicalWarehouse_BusinessObject.Contract;
using MedicalWarehouse_BusinessObject.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MedicalWarehouse_Repository.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        protected DbSet<T> GetDbSet<T>() where T : BaseEntity
        {
            var dbSet = _context.Set<T>();
            return dbSet;
        }
        protected DbSet<T> DbSet
        {
            get
            {
                var dbSet = GetDbSet<T>();
                return dbSet;
            }
        }
        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }
        public Task UpdateAsync(T entity)
        {
            return Task.Run(() => DbSet.Update(entity));
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await GetById(id);
            if (entity == null) return false;
            entity.IsDeleted = true;
            DbSet.Update(entity);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }   
        public virtual async Task<T> GetById(Guid id)
        {
            var queryable = GetQueryable(x => x.Id == id);
            var entity = await queryable.FirstOrDefaultAsync();

            return entity;
        }
        #region Query

        public IQueryable<T> GetQueryable<T>()
        where T : BaseEntity
        {
            IQueryable<T> queryable = GetDbSet<T>(); // like DbSet in this
            return queryable;
        }

        public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate)
        {
            var queryable = GetQueryable<T>();
            if (predicate != null) queryable = queryable.Where(predicate);
            return queryable;
        }

        #endregion
    }
}
