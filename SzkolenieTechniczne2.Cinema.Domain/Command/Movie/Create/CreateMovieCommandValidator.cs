﻿using FluentValidation;

namespace SzkolenieTechniczne2.Cinema.Domain.Command.Movie.Create
{
    public class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Nazwa filmu wymagana")
                .MaximumLength(256)
                .WithMessage("Maksymalna liczba znaków 256.");

            RuleFor(x => x.Year)
                .InclusiveBetween(1900, 2080)
                .WithMessage("Rok musi być pomiędzy 1900 a 2080.");

            RuleFor(x => x.SeanceTime)
                .InclusiveBetween(30, 300)
                .InclusiveBetween(30, 300)
                .WithMessage("Seans musi być pomiędzy 30 i 300 minut.");
        }
    }
}
