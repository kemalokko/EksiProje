using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dnm.Models
{
    public class LoginModels
    {










        //[Required]
        //[Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //[Display(Name ="Şifre")]
        public string Name { get; set; }
        public string Password { get; set; }
        public string Kek { get; set; }
    }
}