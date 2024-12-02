using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositryContracts;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.Core.Services
{
    internal class UsersService : IUsersService
    {
        private readonly IUsersRepositry _usersRepositry;
        public UsersService(IUsersRepositry usersRepositry) 
        {
            _usersRepositry = usersRepositry;
        }
        public async Task<AuthenticationResponse?> LogIn(LogInRequest logInRequest)
        {
            ApplicationUser? user =  await _usersRepositry.GetUserByEmailAndPassword(logInRequest.Email,logInRequest.Password);
            if (user == null) 
            {
                return null;
            }
            return new AuthenticationResponse(user.UserID, user.Email , user.PersonName, user.Gender,"Token",Success: true);
        }

        public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
        {
            //Create a new ApplicationUser objevt from RegisterRequest
            ApplicationUser user = new ApplicationUser() 
            {
                PersonName = registerRequest.PersonName,
                Email = registerRequest.Email,
                Password = registerRequest.Password,
                Gender = registerRequest.Gender.ToString()
            };
            ApplicationUser? registeredUser=await _usersRepositry.AddUser(user);

            if (registeredUser == null) 
            {
                return null;
            }
            //Return success Response 
            return new AuthenticationResponse(registeredUser.UserID, registeredUser.Email, registeredUser.PersonName ,registeredUser.Gender ,"Token" , Success:true);
        }
    }
}
