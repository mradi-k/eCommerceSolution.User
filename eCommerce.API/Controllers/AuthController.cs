using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsersService _usersService;
        public AuthController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        //Endpoint for User Registration use case 
        [HttpPost("register")] //Post api/auth/register
        public async Task<IActionResult>Register(RegisterRequest registerRequest)
        {
            //Check for invalid registerRequest
            if (registerRequest == null) { return BadRequest("Invalid Registation data"); }
            //Call the UsersService to handle registraion 
            AuthenticationResponse? authenticationResponse = await _usersService.Register(registerRequest);

            if (authenticationResponse == null || authenticationResponse.Success == false) { return BadRequest(authenticationResponse); }

            return Ok(authenticationResponse);
        }
        //Endpoint for User login use case 
        [HttpPost("login")]
        public async Task<IActionResult>Login(LogInRequest loginRequest)
        {
            //Check for invalid loginRequest
            if (loginRequest == null) { return BadRequest("Invalid Registation data"); }
            //Call the UserService to hanlde the login 
            AuthenticationResponse? authenticationResponse = await _usersService.LogIn(loginRequest);
            if (authenticationResponse == null || authenticationResponse.Success == false) { return BadRequest(authenticationResponse); }

            return Ok(authenticationResponse);
        }
    }
}
