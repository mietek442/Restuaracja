using Api.Domain.Models;
using Api.Features.TableReservations.Helpers;
using FluentValidation;

namespace Api.Features.Helpers.Validation
{
    public class ReservationValidator : AbstractValidator<ReservationRequest>
    {
        public ReservationValidator()
        {
            RuleFor(e => e.StartTime)
                .NotEmpty().WithMessage("Start time is required.")
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("Start date must be in the future.")
                .LessThan(x => x.EndTime).WithMessage("Start tiem must be sooner than end time");
            RuleFor(x => x.EndTime)
                .NotEmpty().WithMessage("End time is required.")
                .GreaterThan(DateTime.Now).WithMessage("End date must be in the future")
                .GreaterThan(x => x.StartTime).WithMessage("End date must be later than start date");
            RuleFor(e => e.ClientName)
                .NotEmpty().WithMessage("Client name is required.")
                .Length(1, 50).WithMessage("Client name length must be between 0 and 50 characters");
        }
    }
   

}
