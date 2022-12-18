using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using UserApi.Models;

namespace UserApi.Services
{
    public class CadastroService
    {
        private readonly UserManager<User> _userManager;
        public CadastroService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public Result CadastrarUsuario()
        {
            return Result.Fail("Falha ao Cadastrar");
        }
    }
}