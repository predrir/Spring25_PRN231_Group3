using MedicalWarehouse_BusinessObject.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWarehouse_Services.Interface;

    public interface IAuthService
    {
        Task<LoginResponse> SeedRoles();
        Task<LoginResponse> Login(string username, string password);
    }

