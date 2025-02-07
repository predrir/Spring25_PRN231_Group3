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
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
