using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositryContracts;

namespace eCommerce.InfraStructure.Repositories
{
    internal class UserRepository : IUsersRepositry
    {
        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            user.UserID =  Guid.NewGuid();
            return user;
        }
        public async  Task<ApplicationUser?> GetUserByEmailAndPassword(string? Email, string? Password)
        {
            return new ApplicationUser()
            { 
                UserID = Guid.NewGuid(), 
                Email = Email, 
                Password = Password,
                PersonName = "Person Name is Dummy",
                Gender = GenderOptions.Male.ToString(),
            };
        }
    }
}
