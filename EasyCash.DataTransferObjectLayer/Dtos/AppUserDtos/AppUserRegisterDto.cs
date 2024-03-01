using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.DataTransferObjectLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //Validation burda yazilabilir ama SOLID e uygun degil business katmaninda yazacagiz
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
