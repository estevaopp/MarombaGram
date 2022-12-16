using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace UserApi.Models
{
    public class User
    {
        [Required]
        public DateTime BirthDay { get; set; }
    }
}