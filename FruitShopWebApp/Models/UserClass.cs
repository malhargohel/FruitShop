using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FruitShopWebApp.Models
{
    public class UserClass
    {
        [Required(ErrorMessage ="Enter Username !")]
        [Display(Name = "Enter UserName :")]
        [StringLength(maximumLength:8,MinimumLength =3,ErrorMessage =)"Username"]
        public string Uname { get; set; }
        public string Uemail { get; set; }
        public string Upwd { get; set; }
        public char Gender { get; set; }
        public string Uimg { get; set; }

    }
}
