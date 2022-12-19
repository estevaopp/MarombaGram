using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApi.Data.Response
{
    public class CreateUserResponse
    {
        public string? UserName { get; set; }
        public string? Error { get; set; }
        public string? Mensage { get; set; }
    }
}