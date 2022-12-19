using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApi.Data.Dtos
{
    public class UserDto
    {
        public int? Id { get; set; }
        public string? UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public DateTime? BirthDay { get; set; }
    }
}