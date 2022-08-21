using FluentValidation;
using FluentValidation.Validators;
using Validating.Models;

namespace Validating.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty().NotNull();

            RuleFor(customer => customer.Orders)
                .Must(orders => orders.Count > 0).WithMessage("Must take at least 1 order ")
                .Must(orders => orders.Count <= 10).WithMessage("no more than 10 orders");

            RuleForEach(customers => customers.Orders).SetValidator(new OrderValidator());

            RuleFor(customer => customer.Address).SetValidator(new AddressValidator()).When(customer => customer.Address != null).WithMessage("this is bull shitt");
        }
    }

    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.PostCode).NotEmpty();
        }
    }

    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(order => order.Total).GreaterThan(0).WithMessage("invalid order amount!");
        }
    }
}
