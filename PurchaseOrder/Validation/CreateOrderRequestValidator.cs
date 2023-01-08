using FluentValidation;
using PurchaseOrder.Model.Dtos;

namespace PurchaseOrder.Api.Validation {
    public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest> {
        public CreateOrderRequestValidator() {
            RuleFor(x => x.DayOfMonth).InclusiveBetween<CreateOrderRequest, byte>(1, 28);
            RuleFor(x => x.Amount).InclusiveBetween(100, 20_000);
        }
    }

}
