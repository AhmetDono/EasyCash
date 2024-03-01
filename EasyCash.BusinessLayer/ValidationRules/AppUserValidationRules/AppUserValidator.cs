using EasyCash.DataTransferObjectLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.BusinessLayer.ValidationRules.AppUserValidationRules
{
    //AppUser cagirmak yerine register cagirdik cunku sadece lazim olan kolonlari aliyoruz
    public class AppUserValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserValidator()
        {
            //Empty
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field can not be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field can not be empty");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username field can not be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email field can not be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field can not be empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword field can not be empty");

            //Max-Min Length
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Name field can be up to 30 characters.");
            RuleFor(x => x.Name).MinimumLength(6).WithMessage("Name field can be at least 6 characters.");

            //Email Check
            RuleFor(x => x.Email).EmailAddress().WithMessage("Enter a valid email address");

            //Pass Check
            RuleFor(x=>x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Passwords do not match"):
        }
    }
}
