using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordsViewerClient.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="Заполните поле 'Логин' 1")]
        public string Login { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните поле 'Пароль' 2")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните поле 'Подтверждение пароля' 3")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают 4")]
        public string Confirm { get; set; }
    }
}
