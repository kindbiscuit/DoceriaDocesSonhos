using DoceriaDocesSonhos.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Validator
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Nome).NotNull()
                .WithMessage("O doce precisa de um nome!")
                .MinimumLength(3)
                .WithMessage("O nome deve conter mais do que 3 letras");
               
            RuleFor(p => p.Preco)
                .NotNull()
                .GreaterThan(0)
                .WithMessage("O preço deve ser maior do que zero!");
          
            RuleFor(p => p.QuantidadeDisponivel)
                .GreaterThanOrEqualTo(0);
            
            RuleFor(p => p.QuantidadeDisponivel)
                .NotNull()
                .When(p => p.QuantidadeDisponivel == 0)
                .WithMessage("Não há mais disponíveis");
           
            RuleFor(p => p.TipoDeDoce)
                .NotNull();

        }
    }
}
