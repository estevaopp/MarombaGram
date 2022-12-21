using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserApi.Data.Requests;
using UserApi.Data.Response;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroController : ControllerBase
    {
        public CadastroController()
        {
            
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(CreateUserRequest createUserRequest)
        {
            return StatusCode(500);
        }
    }
}