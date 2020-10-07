using Domain.Commands.Persons.Custumers;

namespace Domain.Commands.Validations.Persons.Custumers
{
    public class RemoveCustomerCommandValidation : CustomerValidation<RemoveCustomerCommand>
    {
        public RemoveCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}