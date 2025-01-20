using Microsoft.AspNetCore.Identity;

namespace MedicalWarehouse_BusinessObject.Entity
{
    public class User : IdentityUser
    {
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
