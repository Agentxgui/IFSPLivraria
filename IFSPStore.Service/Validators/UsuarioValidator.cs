using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IFSPLivraria.Domain.Entities;

namespace IFSPLivraria.Service.Validators
{
    public class UsuarioValidator: AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
           

            RuleFor(u => u.Login)
               .NotEmpty().WithMessage("Por Favor informe o login.")
               .NotNull().WithMessage("Por Favor informe o login.");


            RuleFor(u => u.Senha)
               .NotEmpty().WithMessage("Por Favor informe a senha.")
               .NotNull().WithMessage("Por Favor informe a senha.");


        }
    }
}
