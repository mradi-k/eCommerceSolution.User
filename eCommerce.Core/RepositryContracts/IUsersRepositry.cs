
using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositryContracts
{
    /// <summary>
    /// Contract to be implemented by UserRepositry that contains Data Access Logic of User data store 
    /// </summary>
    public interface IUsersRepositry
    {
        /// <summary>
        /// Method to Add a User to data store and return the added User 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ApplicationUser?> AddUser(ApplicationUser user);
        /// <summary>
        /// Method to retrive existing user by their Email and Password
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        Task<ApplicationUser?> GetUserByEmailAndPassword(string?Email, string? Password);
    }
}
