using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Core.DTO;

namespace eCommerce.Core.ServiceContracts
{
    /// <summary>
    /// Contract for users Services that contains usecases for users
    /// </summary>
    public interface IUsersService
    {
        /// <summary>
        /// Method to handle user login use case and returns an AuthenticationResponse Object that contains status of login 
        /// </summary>
        /// <param name="logInRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> LogIn(LogInRequest logInRequest);
        /// <summary>
        /// Method to handle user Registration use case and returns an AuthenticationResponse Object that contains status of User Registration 
        /// </summary>
        /// <param name="registerRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
    }
}
