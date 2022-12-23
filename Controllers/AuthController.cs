using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_Rpg6.Data;
using dotnet_Rpg6.Dtos.Character.User;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_Rpg6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }


        [HttpPostAttribute("register")]   
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User {Username = request.Username}, request.Password
            );
            if(!response.Success){
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}